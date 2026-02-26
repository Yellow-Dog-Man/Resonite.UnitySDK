
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.TextureSheetAnimator
// Generated on: čtvrtek 26. února 2026 10:04:38
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public UnityEngine.Vector2Int TileGridSize { get => TileGridSize_Element.Data; set => TileGridSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> TileGridSize_Element = new();
public global::System.Single AnimationCycleCount { get => AnimationCycleCount_Element.Data; set => AnimationCycleCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnimationCycleCount_Element = new();
public global::PhotonDust.TextureSheetAnimationType AnimationType { get => AnimationType_Element.Data; set => AnimationType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.TextureSheetAnimationType>, global::PhotonDust.TextureSheetAnimationType> AnimationType_Element = new();
public global::System.Int32 RowIndex { get => RowIndex_Element.Data; set => RowIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RowIndex_Element = new();
public global::System.Boolean UseRandomRow { get => UseRandomRow_Element.Data; set => UseRandomRow_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseRandomRow_Element = new();
public global::System.Boolean StartWithRandomOffset { get => StartWithRandomOffset_Element.Data; set => StartWithRandomOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> StartWithRandomOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TileGridSize", TileGridSize_Element.Data.ToResoniteLinkField());
members.Add("AnimationCycleCount", AnimationCycleCount_Element.Data.ToResoniteLinkField());
members.Add("AnimationType", AnimationType_Element.Data.ToResoniteLinkField());
members.Add("RowIndex", RowIndex_Element.Data.ToResoniteLinkField());
members.Add("UseRandomRow", UseRandomRow_Element.Data.ToResoniteLinkField());
members.Add("StartWithRandomOffset", StartWithRandomOffset_Element.Data.ToResoniteLinkField());
}

}
}
