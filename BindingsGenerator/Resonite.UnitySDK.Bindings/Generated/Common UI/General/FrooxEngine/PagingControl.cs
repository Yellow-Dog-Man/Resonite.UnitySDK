
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PagingControl
// Generated on: čtvrtek 26. února 2026 10:03:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PagingControl")]
public partial class PagingControl : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::System.Int32 ItemsPerPage { get => ItemsPerPage_Element.Data; set => ItemsPerPage_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ItemsPerPage_Element = new();
public global::System.Int32 TotalItems { get => TotalItems_Element.Data; set => TotalItems_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> TotalItems_Element = new();
public global::System.Boolean HasMoreItems { get => HasMoreItems_Element.Data; set => HasMoreItems_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HasMoreItems_Element = new();
public global::System.Int32 SkipItems { get => SkipItems_Element.Data; set => SkipItems_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SkipItems_Element = new();
public global::System.String NoItemsLabel { get => NoItemsLabel_Element.Data; set => NoItemsLabel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> NoItemsLabel_Element = new();
public global::System.String PagingInfoLabel { get => PagingInfoLabel_Element.Data; set => PagingInfoLabel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> PagingInfoLabel_Element = new();
public global::System.Int32 TotalPages { get => TotalPages_Element.Data; set => TotalPages_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TotalPages_Element = new();
public global::System.Int32 RemainingItems { get => RemainingItems_Element.Data; set => RemainingItems_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> RemainingItems_Element = new();
public global::FrooxEngine.IField<global::System.String> _label { get => _label_Element.Data; set => _label_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _label_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _previousEnabled { get => _previousEnabled_Element.Data; set => _previousEnabled_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _previousEnabled_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _nextEnabled { get => _nextEnabled_Element.Data; set => _nextEnabled_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _nextEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemsPerPage", ItemsPerPage_Element.Data.ToResoniteLinkField());
members.Add("TotalItems", TotalItems_Element.Data.ToResoniteLinkField());
members.Add("HasMoreItems", HasMoreItems_Element.Data.ToResoniteLinkField());
members.Add("SkipItems", SkipItems_Element.Data.ToResoniteLinkField());
members.Add("NoItemsLabel", NoItemsLabel_Element.Data.ToResoniteLinkField());
members.Add("PagingInfoLabel", PagingInfoLabel_Element.Data.ToResoniteLinkField());
members.Add("TotalPages", TotalPages_Element.Data.ToResoniteLinkField());
members.Add("RemainingItems", RemainingItems_Element.Data.ToResoniteLinkField());
members.Add("_label", _label_Element.Data.ToResoniteReference(context));
members.Add("_previousEnabled", _previousEnabled_Element.Data.ToResoniteReference(context));
members.Add("_nextEnabled", _nextEnabled_Element.Data.ToResoniteReference(context));
}

}
}
