
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedViewBase
// Generated on: pátek 13. února 2026 23:23:02
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Feed", new ResoniteLink.Reference() { });
members.Add("Path", new ResoniteLink.SyncList()
{
    Elements = Path.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("GroupingKeys", new ResoniteLink.SyncList()
{
    Elements = GroupingKeys.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("SearchPhrase", SearchPhrase.ToResoniteLinkField());
members.Add("UpdatingUser", new ResoniteLink.SyncObject() { Members = UpdatingUser.CollectMembers() });
members.Add("ResetViewOnSave", ResetViewOnSave.ToResoniteLinkField());
}

}
}
