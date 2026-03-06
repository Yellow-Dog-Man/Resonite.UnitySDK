
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugFeed
// Generated on: pátek 6. března 2026 14:18:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugFeed")]
public partial class DebugFeed : global::FrooxEngine.Component, global::FrooxEngine.IDataFeedComponent, global::FrooxEngine.IDataFeed

{
    public global::System.Int32 CategoryCount { get => CategoryCount_Element.Data; set => CategoryCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> CategoryCount_Element = new();
public global::System.Int32 LabelItemCount { get => LabelItemCount_Element.Data; set => LabelItemCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> LabelItemCount_Element = new();
public global::System.Int32 StringItemCount { get => StringItemCount_Element.Data; set => StringItemCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> StringItemCount_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> StringValues = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CategoryCount", CategoryCount_Element.ToLinkField(context));
members.Add("LabelItemCount", LabelItemCount_Element.ToLinkField(context));
members.Add("StringItemCount", StringItemCount_Element.ToLinkField(context));
members.Add("StringValues", StringValues.ToLinkList(context, m => m.ToLinkField(context)));
}

}
}
