using FrooxEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrooxEngine
{
    public partial class AudioOutput
    {
        public void SetFrom(UnityEngine.AudioSource audioSource)
        {
            // Set the basics
            base.SetFrom(audioSource);

            Volume = audioSource.volume;
            SpatialBlend = audioSource.spatialBlend;
            Spatialize = audioSource.spatialize;

            MinDistance = audioSource.minDistance;
            MaxDistance = audioSource.maxDistance;

            SpatializationStartDistance = 0.2f;
            SpatializationTransitionRange = 0.5f;

            Pitch = 1;

            DopplerLevel = audioSource.dopplerLevel;

            Priority = audioSource.priority;

            // TODO!!! Is there a good way to classify this here?
            AudioTypeGroup = AudioTypeGroup.SoundEffect;

            // Unity uses everything in the global space
            DistanceSpace = AudioDistanceSpace.Global;

            IgnoreAudioEffects = audioSource.bypassReverbZones || audioSource.bypassEffects;

            switch(audioSource.rolloffMode)
            {
                case AudioRolloffMode.Linear:
                    RolloffMode = Awwdio.AudioRolloffCurve.Linear;
                    break;

                case AudioRolloffMode.Logarithmic:
                    RolloffMode = Awwdio.AudioRolloffCurve.Logarithmic;
                    break;

                case AudioRolloffMode.Custom:
                    Debug.LogWarning("Custom audio rolloff isn't currently supported");
                    RolloffMode = Awwdio.AudioRolloffCurve.Logarithmic;
                    break;
            }
        }
    }

    public partial class AudioClipPlayer
    {
        public void SetFrom(UnityEngine.AudioSource audioSource, IConversionContext context)
        {
            base.SetFrom(audioSource);

            Clip = context.GetAudioClip(audioSource.clip);
        }
    }
}

public class AudioSourceConverter : ResoniteComponentConverter<AudioSource>
{
    public AudioOutputWrapper Output;
    public AudioClipPlayerWrapper Player;

    protected override void UpdateConversion(AudioSource target, IConversionContext context)
    {
        if (Output == null)
            Output = gameObject.AddComponent<AudioOutputWrapper>();

        if (Player == null)
            Player = gameObject.AddComponent<AudioClipPlayerWrapper>();

        Output.Data.SetFrom(target);
        Output.Data.Source = Player.Data;

        Player.Data.SetFrom(target, context);
    }

    protected override void Cleanup()
    {
        if (Output != null)
            DestroyImmediate(Output);

        if (Player != null)
            DestroyImmediate(Player);
    }
}
