
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PagingControl
// Generated on: středa 25. února 2026 16:13:07
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
    public global::System.Int32 ItemsPerPage;
public global::System.Int32 TotalItems;
public global::System.Boolean HasMoreItems;
public global::System.Int32 SkipItems;
public global::System.String NoItemsLabel;
public global::System.String PagingInfoLabel;
public global::System.Int32 TotalPages;
public global::System.Int32 RemainingItems;
public global::FrooxEngine.IField<global::System.String> _label;
public global::FrooxEngine.IField<global::System.Boolean> _previousEnabled;
public global::FrooxEngine.IField<global::System.Boolean> _nextEnabled;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemsPerPage", ItemsPerPage.ToResoniteLinkField());
members.Add("TotalItems", TotalItems.ToResoniteLinkField());
members.Add("HasMoreItems", HasMoreItems.ToResoniteLinkField());
members.Add("SkipItems", SkipItems.ToResoniteLinkField());
members.Add("NoItemsLabel", NoItemsLabel.ToResoniteLinkField());
members.Add("PagingInfoLabel", PagingInfoLabel.ToResoniteLinkField());
members.Add("TotalPages", TotalPages.ToResoniteLinkField());
members.Add("RemainingItems", RemainingItems.ToResoniteLinkField());
members.Add("_label", _label.ToResoniteReference(context));
members.Add("_previousEnabled", _previousEnabled.ToResoniteReference(context));
members.Add("_nextEnabled", _nextEnabled.ToResoniteReference(context));
}

}
}
