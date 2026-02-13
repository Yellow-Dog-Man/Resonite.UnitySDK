
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyAnimationTypeAdapter
// Generated on: pátek 13. února 2026 5:52:33
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyAnimationTypeAdapter")]
public partial class LegacyAnimationTypeAdapter : global::FrooxEngine.Component

{
    public global::FrooxEngine.PhotonDust.LegacyParticleAnimationType Source;
public global::FrooxEngine.IField<global::PhotonDust.TextureSheetAnimationType> Target;
public global::FrooxEngine.IValue<UnityEngine.Vector2Int> AnimationTiles;
public global::FrooxEngine.IField<global::System.Boolean> AnimationEnabled;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", Source.ToResoniteLinkField());
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("AnimationTiles", new ResoniteLink.Reference() { });
members.Add("AnimationEnabled", new ResoniteLink.Reference() { });
}

}
}
