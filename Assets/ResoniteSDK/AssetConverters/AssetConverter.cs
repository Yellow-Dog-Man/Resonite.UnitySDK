using FrooxEngine;
using ResoniteLink;
using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public abstract class AssetConverter : MonoBehaviour
{
    public AssetMessagePostProcessor PostProcessor;

    public ulong LastTimestamp;

    public void Convert(IConversionContext context, LinkInterface link)
    {
        var data = GenerateConversion();
        var name = AssetName;

        // Run any postprocessing
        PostProcessor?.Process(data);

        // Store the timestamp after the conversion
        // The timestamp can change during the conversion generation, so we make sure to change it after
        LastTimestamp = GetAssetTimestamp();

        Task.Run(async () =>
        {
            var result = await SendConversion(data, link);

            if (!result.Success)
            {
                Debug.LogError($"Failed to convert {AssetClass} {name}: {result.ErrorInfo}");
                return;
            }

            // Assign the URL of the converted asset
            var updateData = UpdateProvider(result.AssetURL, context);

            // Send the update!
            // We could just do it all at once, but having it pop piece by piece is more interactive and looks cooler :3
            var update = new UpdateComponent()
            {
                MessageID = context.GetUniqueMessageId($"Update{AssetClass}Provider_{name}"),
                Data = updateData,
            };

            var updateResult = await link.UpdateComponent(update);

            if (!updateResult.Success)
                Debug.LogError($"Failed to update asset provider with URL: " + updateResult.ErrorInfo);
        }).Wait();
    }

    public virtual bool HasAssetChanged() => GetAssetTimestamp() != LastTimestamp;

    protected abstract ulong GetAssetTimestamp();

    public abstract string AssetClass { get; }
    public abstract string AssetName { get; }
    protected abstract ResoniteLink.Message GenerateConversion();
    protected abstract Task<AssetData> SendConversion(ResoniteLink.Message message, LinkInterface link);
    protected abstract ResoniteLink.Component UpdateProvider(Uri assetUrl, IConversionContext context);
}

public abstract class AssetConverter<TProvider, TUnity, TResonite> : AssetConverter
    where TProvider : FrooxEngine.Component, IAssetProvider<TResonite>, new()
    where TResonite : FrooxEngine.IAsset
    where TUnity : UnityEngine.Object
{
    public TUnity Source;
    public ResRef<TProvider> Provider;

    public void Initialize(TUnity source, AssetMessagePostProcessor postProcessor)
    {
        if (Source != null || Provider != null)
            throw new InvalidOperationException("This converter has already been initialized");

        if (source == null)
            throw new ArgumentNullException(nameof(source));

        this.Source = source;
        this.PostProcessor = postProcessor;

        gameObject.name = $"{typeof(TResonite).Name} - {AssetName}";

        Provider = gameObject.AddResoniteComponent<TProvider>();

        Provider.Binding.Enabled = true;
        Provider.Binding.persistent = true;
    }

    public override bool HasAssetChanged()
    {
        // If the URL is missing, it needs to be converted again
        if (Provider.Binding is IStaticAssetProvider staticProvider && staticProvider.URL == null)
            return true;

        if (PostProcessor != null && PostProcessor.HasChanged())
            return true;

        return base.HasAssetChanged();
    }

    protected override ulong GetAssetTimestamp()
    {
        var assetPath = AssetDatabase.GetAssetPath(Source);

        if (assetPath == "Library/unity default resources" ||
            assetPath == "Resources/unity_builtin_extra")
            return 0;

        if (!string.IsNullOrEmpty(assetPath))
        {
            var importer = AssetImporter.GetAtPath(assetPath);

            if (importer == null)
                throw new Exception($"Could not get importer for asset path: {assetPath}");

            return importer.assetTimeStamp;
        }
        else
        {
            // This is a procedural asset. There's not a nice general way to determine if the asset has changed or not
            // So we just force it to be re-converted every single time
            // TODO!!! Potential ways to determine if asset changed or not? Could be for specific assets, like
            // for textures we could use the image hash potentially. But that might be more expensive.
            return (ulong)DateTime.UtcNow.Ticks;
        }
    }
}
