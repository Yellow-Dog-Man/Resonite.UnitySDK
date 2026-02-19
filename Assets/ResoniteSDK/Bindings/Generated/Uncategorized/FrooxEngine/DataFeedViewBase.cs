
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedViewBase
// Generated on: čtvrtek 19. února 2026 8:00:17
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.IDataFeedComponent Feed;
public System.Collections.Generic.List<global::System.String> Path;
public System.Collections.Generic.List<global::System.String> GroupingKeys;
public global::System.String SearchPhrase;
public global::FrooxEngine.UserRef UpdatingUser;
public global::System.Boolean ResetViewOnSave;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Feed", Feed.ToResoniteReference(context));
members.Add("Path", new ResoniteLink.SyncList()
{
    Elements = Path.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("GroupingKeys", new ResoniteLink.SyncList()
{
    Elements = GroupingKeys.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("SearchPhrase", SearchPhrase.ToResoniteLinkField());
members.Add("UpdatingUser", new ResoniteLink.SyncObject() { Members = UpdatingUser.CollectMembers(context) });
members.Add("ResetViewOnSave", ResetViewOnSave.ToResoniteLinkField());
}

}
}
