
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeUnlitMaterial
// Generated on: sobota 14. února 2026 8:56:58
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumeUnlitMaterial")]
public partial class VolumeUnlitMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::FrooxEngine.VolumeUnlitMaterial.DisplayMode Mode;
public global::FrooxEngine.BlendMode BlendMode;
public global::System.Int32 RenderQueue;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D> Volume;
public global::System.Single StepSize;
public global::System.Single Gain;
public global::System.Single Exp;
public global::System.Single AccumulationCutoff;
public global::System.Single HitThreshold;
public global::System.Single InputRange;
public global::System.Single InputOffset;
public global::System.Boolean UseAlphaChannel;
public System.Collections.Generic.List<global::FrooxEngine.VolumeUnlitMaterial.SlicePlane> Slices;
public System.Collections.Generic.List<global::FrooxEngine.VolumeUnlitMaterial.Highlight> Highlights;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("RenderQueue", RenderQueue.ToResoniteLinkField());
members.Add("Volume", Volume.ToResoniteReference(context));
members.Add("StepSize", StepSize.ToResoniteLinkField());
members.Add("Gain", Gain.ToResoniteLinkField());
members.Add("Exp", Exp.ToResoniteLinkField());
members.Add("AccumulationCutoff", AccumulationCutoff.ToResoniteLinkField());
members.Add("HitThreshold", HitThreshold.ToResoniteLinkField());
members.Add("InputRange", InputRange.ToResoniteLinkField());
members.Add("InputOffset", InputOffset.ToResoniteLinkField());
members.Add("UseAlphaChannel", UseAlphaChannel.ToResoniteLinkField());
members.Add("Slices", new ResoniteLink.SyncList()
{
    Elements = Slices.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("Highlights", new ResoniteLink.SyncList()
{
    Elements = Highlights.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
