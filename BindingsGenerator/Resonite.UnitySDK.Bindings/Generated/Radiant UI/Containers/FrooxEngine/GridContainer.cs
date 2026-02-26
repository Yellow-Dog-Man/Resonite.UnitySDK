
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridContainer
// Generated on: čtvrtek 26. února 2026 15:09:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridContainer")]
public partial class GridContainer : global::FrooxEngine.FacetContainer, global::FrooxEngine.ICustomInspector

{
    public global::System.Boolean RecalculateOnSizeChange { get => RecalculateOnSizeChange_Element.Data; set => RecalculateOnSizeChange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RecalculateOnSizeChange_Element = new();
public global::System.Nullable<UnityEngine.Vector2Int> CellCount { get => CellCount_Element.Data; set => CellCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector2Int>>, global::System.Nullable<UnityEngine.Vector2Int>> CellCount_Element = new();
public global::System.Nullable<UnityEngine.Vector2> CellSize { get => CellSize_Element.Data; set => CellSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector2>>, global::System.Nullable<UnityEngine.Vector2>> CellSize_Element = new();
public UnityEngine.Vector2 Padding { get => Padding_Element.Data; set => Padding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Padding_Element = new();
public global::System.Nullable<UnityEngine.Vector2> _lastCalculatedCenteringOffset { get => _lastCalculatedCenteringOffset_Element.Data; set => _lastCalculatedCenteringOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector2>>, global::System.Nullable<UnityEngine.Vector2>> _lastCalculatedCenteringOffset_Element = new();
public global::System.Nullable<UnityEngine.Vector2> _lastCalculatedCellSize { get => _lastCalculatedCellSize_Element.Data; set => _lastCalculatedCellSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector2>>, global::System.Nullable<UnityEngine.Vector2>> _lastCalculatedCellSize_Element = new();
public global::System.Nullable<UnityEngine.Vector2> _lastCalculatedPadding { get => _lastCalculatedPadding_Element.Data; set => _lastCalculatedPadding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector2>>, global::System.Nullable<UnityEngine.Vector2>> _lastCalculatedPadding_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RecalculateOnSizeChange", RecalculateOnSizeChange_Element.ToLinkField(context));
members.Add("CellCount", CellCount_Element.ToLinkField(context));
members.Add("CellSize", CellSize_Element.ToLinkField(context));
members.Add("Padding", Padding_Element.ToLinkField(context));
members.Add("_lastCalculatedCenteringOffset", _lastCalculatedCenteringOffset_Element.ToLinkField(context));
members.Add("_lastCalculatedCellSize", _lastCalculatedCellSize_Element.ToLinkField(context));
members.Add("_lastCalculatedPadding", _lastCalculatedPadding_Element.ToLinkField(context));
}

}
}
