using FrooxEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public static class AudioSourceHelper
{
    public static void SetFrom(this FrooxEngine.AudioOutput resonite, UnityEngine.AudioSource unity)
    {
        // Set the basics
        resonite.SetFrom((UnityEngine.Behaviour)unity);

        resonite.Volume = unity.volume;
        resonite.SpatialBlend = unity.spatialBlend;
        resonite.Spatialize = unity.spatialize;

        resonite.MinDistance = unity.minDistance;
        resonite.MaxDistance = unity.maxDistance;

        resonite.SpatializationStartDistance = 0.2f;
        resonite.SpatializationTransitionRange = 0.5f;

        resonite.Pitch = 1;

        resonite.DopplerLevel = unity.dopplerLevel;

        resonite.Priority = unity.priority;

        // TODO!!! Is there a good way to classify this here?
        resonite.AudioTypeGroup = AudioTypeGroup.SoundEffect;

        // Unity uses everything in the global space
        resonite.DistanceSpace = AudioDistanceSpace.Global;

        resonite.IgnoreAudioEffects = unity.bypassReverbZones || unity.bypassEffects;

        switch (unity.rolloffMode)
        {
            case AudioRolloffMode.Linear:
                resonite.RolloffMode = Awwdio.AudioRolloffCurve.Linear;
                break;

            case AudioRolloffMode.Logarithmic:
                resonite.RolloffMode = Awwdio.AudioRolloffCurve.Logarithmic;
                break;

            case AudioRolloffMode.Custom:
                Debug.LogWarning("Custom audio rolloff isn't currently supported");
                resonite.RolloffMode = Awwdio.AudioRolloffCurve.Logarithmic;
                break;
        }
    }
    public static void SetFrom(this FrooxEngine.AudioClipPlayer resonite, UnityEngine.AudioSource unity, IConversionContext context)
    {
        resonite.SetFrom((UnityEngine.Behaviour)unity);

        resonite.Clip = context.GetAudioClip(unity.clip);

        var state = new PlaybackState();

        state.Position = 0;
        state.Playing = unity.playOnAwake;
        state.Loop = unity.loop;
        state.Speed = unity.pitch;

        resonite.playback = state;
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
