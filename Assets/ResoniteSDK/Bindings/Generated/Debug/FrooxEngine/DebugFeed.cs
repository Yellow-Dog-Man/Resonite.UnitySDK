
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugFeed
// Generated on: pátek 13. února 2026 5:51:12
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugFeed")]
public partial class DebugFeed : global::FrooxEngine.Component, global::FrooxEngine.IDataFeedComponent, global::FrooxEngine.IDataFeed

{
    public global::System.Int32 CategoryCount;
public global::System.Int32 LabelItemCount;
public global::System.Int32 StringItemCount;
public System.Collections.Generic.List<global::System.String> StringValues;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CategoryCount", CategoryCount.ToResoniteLinkField());
members.Add("LabelItemCount", LabelItemCount.ToResoniteLinkField());
members.Add("StringItemCount", StringItemCount.ToResoniteLinkField());
members.Add("StringValues", new ResoniteLink.SyncList()
{
    Elements = StringValues.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
}

}
}
