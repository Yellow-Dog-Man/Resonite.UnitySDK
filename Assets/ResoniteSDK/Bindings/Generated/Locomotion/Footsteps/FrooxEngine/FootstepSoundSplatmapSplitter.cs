
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FootstepSoundSplatmapSplitter
// Generated on: úterý 24. února 2026 18:17:50
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> SplatMap;
public global::FrooxEngine.IFootstepSoundMaterial R_SoundMaterial;
public global::FrooxEngine.IFootstepSoundMaterial G_SoundMaterial;
public global::FrooxEngine.IFootstepSoundMaterial B_SoundMaterial;
public global::FrooxEngine.IFootstepSoundMaterial A_SoundMaterial;
public global::System.Boolean BlendSounds;
public global::System.Single MinimumThreshold;
public global::System.Single R_Weight;
public global::System.Single G_Weight;
public global::System.Single B_Weight;
public global::System.Single A_Weight;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SplatMap", SplatMap.ToResoniteReference(context));
members.Add("R_SoundMaterial", R_SoundMaterial.ToResoniteReference(context));
members.Add("G_SoundMaterial", G_SoundMaterial.ToResoniteReference(context));
members.Add("B_SoundMaterial", B_SoundMaterial.ToResoniteReference(context));
members.Add("A_SoundMaterial", A_SoundMaterial.ToResoniteReference(context));
members.Add("BlendSounds", BlendSounds.ToResoniteLinkField());
members.Add("MinimumThreshold", MinimumThreshold.ToResoniteLinkField());
members.Add("R_Weight", R_Weight.ToResoniteLinkField());
members.Add("G_Weight", G_Weight.ToResoniteLinkField());
members.Add("B_Weight", B_Weight.ToResoniteLinkField());
members.Add("A_Weight", A_Weight.ToResoniteLinkField());
}

}
}
