
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedViewBase
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataFeedViewBase")]
public abstract partial class DataFeedViewBase : global::FrooxEngine.Component, global::FrooxEngine.IDataFeedView

{
    public global::FrooxEngine.IDataFeedComponent Feed { get => Feed_Element.Data; set => Feed_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IDataFeedComponent>, global::FrooxEngine.IDataFeedComponent> Feed_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> Path = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> GroupingKeys = new();
public global::System.String SearchPhrase { get => SearchPhrase_Element.Data; set => SearchPhrase_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SearchPhrase_Element = new();
public global::FrooxEngine.UserRef UpdatingUser = new();
public global::System.Boolean ResetViewOnSave { get => ResetViewOnSave_Element.Data; set => ResetViewOnSave_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ResetViewOnSave_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Feed", Feed_Element.ToLinkReference(context));
members.Add("Path", Path.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("GroupingKeys", GroupingKeys.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("SearchPhrase", SearchPhrase_Element.ToLinkField(context));
members.Add("UpdatingUser", UpdatingUser.ToLinkSyncObject(context));
members.Add("ResetViewOnSave", ResetViewOnSave_Element.ToLinkField(context));
}

}
}
