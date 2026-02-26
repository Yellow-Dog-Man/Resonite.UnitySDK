
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeUnlitMaterial
// Generated on: čtvrtek 26. února 2026 15:07:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumeUnlitMaterial")]
public partial class VolumeUnlitMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public global::FrooxEngine.VolumeUnlitMaterial.DisplayMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VolumeUnlitMaterial.DisplayMode>, global::FrooxEngine.VolumeUnlitMaterial.DisplayMode> Mode_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D> Volume { get => Volume_Element.Data; set => Volume_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture3D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture3D>> Volume_Element = new();
public global::System.Single StepSize { get => StepSize_Element.Data; set => StepSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StepSize_Element = new();
public global::System.Single Gain { get => Gain_Element.Data; set => Gain_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Gain_Element = new();
public global::System.Single Exp { get => Exp_Element.Data; set => Exp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exp_Element = new();
public global::System.Single AccumulationCutoff { get => AccumulationCutoff_Element.Data; set => AccumulationCutoff_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AccumulationCutoff_Element = new();
public global::System.Single HitThreshold { get => HitThreshold_Element.Data; set => HitThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HitThreshold_Element = new();
public global::System.Single InputRange { get => InputRange_Element.Data; set => InputRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InputRange_Element = new();
public global::System.Single InputOffset { get => InputOffset_Element.Data; set => InputOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InputOffset_Element = new();
public global::System.Boolean UseAlphaChannel { get => UseAlphaChannel_Element.Data; set => UseAlphaChannel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseAlphaChannel_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.VolumeUnlitMaterial.SlicePlane>, global::FrooxEngine.VolumeUnlitMaterial.SlicePlane> Slices = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.VolumeUnlitMaterial.Highlight>, global::FrooxEngine.VolumeUnlitMaterial.Highlight> Highlights = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
members.Add("Volume", Volume_Element.ToLinkReference(context));
members.Add("StepSize", StepSize_Element.ToLinkField(context));
members.Add("Gain", Gain_Element.ToLinkField(context));
members.Add("Exp", Exp_Element.ToLinkField(context));
members.Add("AccumulationCutoff", AccumulationCutoff_Element.ToLinkField(context));
members.Add("HitThreshold", HitThreshold_Element.ToLinkField(context));
members.Add("InputRange", InputRange_Element.ToLinkField(context));
members.Add("InputOffset", InputOffset_Element.ToLinkField(context));
members.Add("UseAlphaChannel", UseAlphaChannel_Element.ToLinkField(context));
members.Add("Slices", Slices.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("Highlights", Highlights.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
