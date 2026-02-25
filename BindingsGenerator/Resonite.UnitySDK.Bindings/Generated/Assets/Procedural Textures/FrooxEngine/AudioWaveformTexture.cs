
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioWaveformTexture
// Generated on: středa 25. února 2026 16:13:05
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioWaveformTexture")]
public partial class AudioWaveformTexture : global::FrooxEngine.ProceduralTexture

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> Clip;
public UnityEngine.ColorX BackgroundColor;
public UnityEngine.ColorX ForegroundColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip.ToResoniteReference(context));
members.Add("BackgroundColor", BackgroundColor.ToResoniteLinkField());
members.Add("ForegroundColor", ForegroundColor.ToResoniteLinkField());
}

}
}
