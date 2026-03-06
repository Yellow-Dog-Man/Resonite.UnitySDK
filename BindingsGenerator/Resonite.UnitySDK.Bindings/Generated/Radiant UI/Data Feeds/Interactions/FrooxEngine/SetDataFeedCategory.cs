
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SetDataFeedCategory
// Generated on: pátek 6. března 2026 14:19:02
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SetDataFeedCategory")]
public partial class SetDataFeedCategory : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.IDataFeedView View { get => View_Element.Data; set => View_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IDataFeedView>, global::FrooxEngine.IDataFeedView> View_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> CategoryPath = new();
public global::System.Boolean IsInsideCategoryPath { get => IsInsideCategoryPath_Element.Data; set => IsInsideCategoryPath_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsInsideCategoryPath_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("View", View_Element.ToLinkReference(context));
members.Add("CategoryPath", CategoryPath.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("IsInsideCategoryPath", IsInsideCategoryPath_Element.ToLinkField(context));
}

}
}
