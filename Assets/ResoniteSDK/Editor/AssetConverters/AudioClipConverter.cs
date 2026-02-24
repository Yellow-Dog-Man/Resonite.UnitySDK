using FrooxEngine;
using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.IO;
using UnityEditor;
using UnityEngine;
using Elements.Assets;

public class AudioClipConverter : AssetConverter<StaticAudioClipWrapper, StaticAudioClip, UnityEngine.AudioClip, FrooxEngine.AudioClip>
{
    public AudioClipConverter(UnityEngine.AudioClip source, Transform assetsRoot) : base(source, assetsRoot)
    {
    }

    public override string AssetClass => "AudioClip";
    public override string AssetName => Source.name;

    protected override Message GenerateConversion() => ConvertAudioClip(Source);

    protected override async Task<AssetData> SendConversion(Message message, LinkInterface link)
    {
        switch(message)
        {
            case ImportAudioClipFile file:
                return await link.ImportAudioClip(file);

            case ImportAudioClipRawData rawData:
                return await link.ImportAudioClip(rawData);

            default:
                throw new NotSupportedException("Unsupported conversion message: " + message.GetType());
        }
    }

    protected override ResoniteLink.Component UpdateProvider(Uri assetUrl, IConversionContext context)
    {
        Provider.Data.URL = assetUrl;

        return Provider.CollectData(context);
    }

    public static ResoniteLink.Message ConvertAudioClip(UnityEngine.AudioClip audioClip)
    {
        // First try to import it as a file. This is easiest and will preserve most data
        // Rather than just extracting the raw pixels
        var assetPath = AssetDatabase.GetAssetPath(audioClip);

        if (!string.IsNullOrWhiteSpace(assetPath))
        {
            assetPath = Path.GetFullPath(assetPath);

            if (File.Exists(assetPath) && AssetConversionHelper.IsAudioFileSupportedByResonite(assetPath))
                return new ImportAudioClipFile() { FilePath = assetPath };
        }

        // Fallback - read the raw audio data
        var import = new ImportAudioClipRawData();

        import.ChannelCount = audioClip.channels;
        import.SampleCount = audioClip.samples;
        import.SampleRate = audioClip.frequency;

        var rawData = import.AccessRawData();

        var dataArray = new float[rawData.Length];

        if (!audioClip.GetData(dataArray, 0))
            throw new Exception($"Failed to read audio data from {audioClip}. Channels: {import.ChannelCount}, " +
                $"SampleCount: {import.SampleCount}, SampleRate: {import.SampleRate}");

        dataArray.AsSpan().CopyTo(rawData);

        return import;
    }
}
