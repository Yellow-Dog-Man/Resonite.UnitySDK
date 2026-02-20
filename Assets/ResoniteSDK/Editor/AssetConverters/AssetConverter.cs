using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public abstract class AssetConverter
{
    ulong lastTimestamp;

    public void Convert(AssetConversionManager manager, LinkInterface link)
    {
        var data = GenerateConversion();
        var name = AssetName;

        // Store the timestamp after the conversion
        // The timestamp can change during the conversion generation, so we make sure to change it after
        lastTimestamp = GetAssetTimestamp();

        Task.Run(async () =>
        {
            var result = await SendConversion(data, link);

            if (!result.Success)
            {
                Debug.LogError($"Failed to convert {AssetClass} {name}: {result.ErrorInfo}");
                return;
            }

            // Assign the URL of the converted asset
            var updateData = UpdateProvider(result.AssetURL, manager.Converter);

            // Send the update! 
            // We could just do it all at once, but having it pop piece by piece is more interactive and looks cooler :3
            var update = new UpdateComponent()
            {
                MessageID = manager.Converter.GetUniqueMessageId($"Update{AssetClass}Provider_{name}"),
                Data = updateData,
            };

            var updateResult = await link.UpdateComponent(update);

            if (!updateResult.Success)
                Debug.LogError($"Failed to update asset provider with URL: " + updateResult.ErrorInfo);
        }).Wait();
    }

    public virtual bool HasAssetChanged() => GetAssetTimestamp() != lastTimestamp;

    protected abstract ulong GetAssetTimestamp();

    protected abstract string AssetClass { get; } 
    protected abstract string AssetName { get; }
    protected abstract ResoniteLink.Message GenerateConversion();
    protected abstract Task<AssetData> SendConversion(ResoniteLink.Message message, LinkInterface link);
    protected abstract ResoniteLink.Component UpdateProvider(Uri assetUrl, IConversionContext context);
}

public abstract class AssetConverter<TWrapper, TProvider, TUnity, TResonite> : AssetConverter
    where TWrapper : ResoniteComponent<TProvider>
    where TProvider : FrooxEngine.Component, IAssetProvider<TResonite>, new()
    where TResonite : FrooxEngine.IAsset
    where TUnity : UnityEngine.Object
{
    public readonly TUnity Source;
    public TWrapper Provider { get; private set; }

    protected AssetConverter(TUnity source, Transform assetsRoot)
    {
        if(source == null)
            throw new ArgumentNullException(nameof(source));

        this.Source = source;

        var root = new GameObject($"{typeof(TResonite).Name} - {AssetName}");
        root.transform.parent = assetsRoot;

        Provider = root.AddComponent<TWrapper>();

        Provider.Data.Enabled = true;
        Provider.Data.persistent = true;
    }

    protected override ulong GetAssetTimestamp()
    {
        var assetPath = AssetDatabase.GetAssetPath(Source);

        if (assetPath == "Library/unity default resources")
            return 0;

        if (assetPath == null)
            throw new Exception($"Could not get asset path for asset: {Source}");

        var importer = AssetImporter.GetAtPath(assetPath);

        if (importer == null)
            throw new Exception($"Could not get importer for asset path: {assetPath}");

        return importer.assetTimeStamp;
    }
}