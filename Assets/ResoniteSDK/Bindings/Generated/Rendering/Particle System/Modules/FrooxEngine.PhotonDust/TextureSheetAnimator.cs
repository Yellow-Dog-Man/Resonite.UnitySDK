
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.TextureSheetAnimator
// Generated on: čtvrtek 19. února 2026 8:00:21
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.TextureSheetAnimator")]
public partial class TextureSheetAnimator : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector2Int TileGridSize;
public global::System.Single AnimationCycleCount;
public global::PhotonDust.TextureSheetAnimationType AnimationType;
public global::System.Int32 RowIndex;
public global::System.Boolean UseRandomRow;
public global::System.Boolean StartWithRandomOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TileGridSize", TileGridSize.ToResoniteLinkField());
members.Add("AnimationCycleCount", AnimationCycleCount.ToResoniteLinkField());
members.Add("AnimationType", AnimationType.ToResoniteLinkField());
members.Add("RowIndex", RowIndex.ToResoniteLinkField());
members.Add("UseRandomRow", UseRandomRow.ToResoniteLinkField());
members.Add("StartWithRandomOffset", StartWithRandomOffset.ToResoniteLinkField());
}

}
}
