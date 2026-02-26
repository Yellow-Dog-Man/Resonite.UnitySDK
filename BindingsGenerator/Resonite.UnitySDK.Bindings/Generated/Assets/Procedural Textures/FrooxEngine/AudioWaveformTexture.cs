
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioWaveformTexture
// Generated on: čtvrtek 26. února 2026 15:07:56
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> Clip { get => Clip_Element.Data; set => Clip_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> Clip_Element = new();
public UnityEngine.ColorX BackgroundColor { get => BackgroundColor_Element.Data; set => BackgroundColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BackgroundColor_Element = new();
public UnityEngine.ColorX ForegroundColor { get => ForegroundColor_Element.Data; set => ForegroundColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> ForegroundColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip_Element.ToLinkReference(context));
members.Add("BackgroundColor", BackgroundColor_Element.ToLinkField(context));
members.Add("ForegroundColor", ForegroundColor_Element.ToLinkField(context));
}

}
}
