using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public abstract class AssetConversionJob
{
    public void Convert(AssetConversionManager manager, LinkInterface link)
    {
        var data = GenerateConversion();
        var name = AssetName;

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

    protected abstract string AssetClass { get; }
    protected abstract string AssetName { get; }
    protected abstract ResoniteLink.Message GenerateConversion();
    protected abstract Task<AssetData> SendConversion(ResoniteLink.Message message, LinkInterface link);
    protected abstract ResoniteLink.Component UpdateProvider(Uri assetUrl, IConversionContext context);
}