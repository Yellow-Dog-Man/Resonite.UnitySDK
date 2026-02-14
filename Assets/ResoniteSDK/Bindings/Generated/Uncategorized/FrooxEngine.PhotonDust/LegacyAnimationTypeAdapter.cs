
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyAnimationTypeAdapter
// Generated on: sobota 14. února 2026 8:58:45
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteLinkField());
members.Add("Target", Target.ToResoniteReference(context));
members.Add("AnimationTiles", AnimationTiles.ToResoniteReference(context));
members.Add("AnimationEnabled", AnimationEnabled.ToResoniteReference(context));
}

}
}
