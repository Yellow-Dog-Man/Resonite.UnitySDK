
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FootstepSoundSplatmapSplitter
// Generated on: pátek 13. února 2026 5:51:13
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SplatMap", new ResoniteLink.Reference() { });
members.Add("R_SoundMaterial", new ResoniteLink.Reference() { });
members.Add("G_SoundMaterial", new ResoniteLink.Reference() { });
members.Add("B_SoundMaterial", new ResoniteLink.Reference() { });
members.Add("A_SoundMaterial", new ResoniteLink.Reference() { });
members.Add("BlendSounds", BlendSounds.ToResoniteLinkField());
members.Add("MinimumThreshold", MinimumThreshold.ToResoniteLinkField());
members.Add("R_Weight", R_Weight.ToResoniteLinkField());
members.Add("G_Weight", G_Weight.ToResoniteLinkField());
members.Add("B_Weight", B_Weight.ToResoniteLinkField());
members.Add("A_Weight", A_Weight.ToResoniteLinkField());
}

}
}
