
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FootstepSoundSplatmapSplitter
// Generated on: čtvrtek 26. února 2026 10:03:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FootstepSoundSplatmapSplitter")]
public partial class FootstepSoundSplatmapSplitter : global::FrooxEngine.Component, global::FrooxEngine.IFootstepSoundMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> SplatMap { get => SplatMap_Element.Data; set => SplatMap_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> SplatMap_Element = new();
public global::FrooxEngine.IFootstepSoundMaterial R_SoundMaterial { get => R_SoundMaterial_Element.Data; set => R_SoundMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IFootstepSoundMaterial>, global::FrooxEngine.IFootstepSoundMaterial> R_SoundMaterial_Element = new();
public global::FrooxEngine.IFootstepSoundMaterial G_SoundMaterial { get => G_SoundMaterial_Element.Data; set => G_SoundMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IFootstepSoundMaterial>, global::FrooxEngine.IFootstepSoundMaterial> G_SoundMaterial_Element = new();
public global::FrooxEngine.IFootstepSoundMaterial B_SoundMaterial { get => B_SoundMaterial_Element.Data; set => B_SoundMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IFootstepSoundMaterial>, global::FrooxEngine.IFootstepSoundMaterial> B_SoundMaterial_Element = new();
public global::FrooxEngine.IFootstepSoundMaterial A_SoundMaterial { get => A_SoundMaterial_Element.Data; set => A_SoundMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IFootstepSoundMaterial>, global::FrooxEngine.IFootstepSoundMaterial> A_SoundMaterial_Element = new();
public global::System.Boolean BlendSounds { get => BlendSounds_Element.Data; set => BlendSounds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> BlendSounds_Element = new();
public global::System.Single MinimumThreshold { get => MinimumThreshold_Element.Data; set => MinimumThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinimumThreshold_Element = new();
public global::System.Single R_Weight { get => R_Weight_Element.Data; set => R_Weight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> R_Weight_Element = new();
public global::System.Single G_Weight { get => G_Weight_Element.Data; set => G_Weight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> G_Weight_Element = new();
public global::System.Single B_Weight { get => B_Weight_Element.Data; set => B_Weight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> B_Weight_Element = new();
public global::System.Single A_Weight { get => A_Weight_Element.Data; set => A_Weight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> A_Weight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SplatMap", SplatMap_Element.Data.ToResoniteReference(context));
members.Add("R_SoundMaterial", R_SoundMaterial_Element.Data.ToResoniteReference(context));
members.Add("G_SoundMaterial", G_SoundMaterial_Element.Data.ToResoniteReference(context));
members.Add("B_SoundMaterial", B_SoundMaterial_Element.Data.ToResoniteReference(context));
members.Add("A_SoundMaterial", A_SoundMaterial_Element.Data.ToResoniteReference(context));
members.Add("BlendSounds", BlendSounds_Element.Data.ToResoniteLinkField());
members.Add("MinimumThreshold", MinimumThreshold_Element.Data.ToResoniteLinkField());
members.Add("R_Weight", R_Weight_Element.Data.ToResoniteLinkField());
members.Add("G_Weight", G_Weight_Element.Data.ToResoniteLinkField());
members.Add("B_Weight", B_Weight_Element.Data.ToResoniteLinkField());
members.Add("A_Weight", A_Weight_Element.Data.ToResoniteLinkField());
}

}
}
