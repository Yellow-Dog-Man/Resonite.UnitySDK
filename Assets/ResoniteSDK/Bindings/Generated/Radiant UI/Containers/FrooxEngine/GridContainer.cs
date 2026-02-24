
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridContainer
// Generated on: úterý 24. února 2026 18:20:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridContainer")]
public partial class GridContainer : global::FrooxEngine.FacetContainer, global::FrooxEngine.ICustomInspector

{
    public global::System.Boolean RecalculateOnSizeChange;
public global::System.Nullable<UnityEngine.Vector2Int> CellCount;
public global::System.Nullable<UnityEngine.Vector2> CellSize;
public UnityEngine.Vector2 Padding;
public global::System.Nullable<UnityEngine.Vector2> _lastCalculatedCenteringOffset;
public global::System.Nullable<UnityEngine.Vector2> _lastCalculatedCellSize;
public global::System.Nullable<UnityEngine.Vector2> _lastCalculatedPadding;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RecalculateOnSizeChange", RecalculateOnSizeChange.ToResoniteLinkField());
members.Add("CellCount", CellCount.ToResoniteLinkField());
members.Add("CellSize", CellSize.ToResoniteLinkField());
members.Add("Padding", Padding.ToResoniteLinkField());
members.Add("_lastCalculatedCenteringOffset", _lastCalculatedCenteringOffset.ToResoniteLinkField());
members.Add("_lastCalculatedCellSize", _lastCalculatedCellSize.ToResoniteLinkField());
members.Add("_lastCalculatedPadding", _lastCalculatedPadding.ToResoniteLinkField());
}

}
}
