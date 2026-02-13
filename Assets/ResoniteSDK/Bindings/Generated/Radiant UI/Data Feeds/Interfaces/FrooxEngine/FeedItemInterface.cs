
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedItemInterface
// Generated on: pátek 13. února 2026 5:52:18
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedItemInterface")]
public partial class FeedItemInterface : global::FrooxEngine.Component

{
    public global::System.Boolean HasData;
public global::FrooxEngine.IField<global::System.String> ItemName;
public global::FrooxEngine.IField<global::System.String> ItemKey;
public global::FrooxEngine.IField<global::System.String> ItemDescription;
public global::FrooxEngine.IField<global::System.Boolean> HasDescription;
public global::FrooxEngine.Slot DescriptionCleanup;
public global::FrooxEngine.IField<System.Uri> ItemIcon;
public global::FrooxEngine.IField<global::System.Boolean> HasIcon;
public global::FrooxEngine.Slot IconCleanup;
public global::FrooxEngine.SyncRef<global::FrooxEngine.IDataFeedView> View;
public global::FrooxEngine.FeedItemInterface ParentContainer;
public global::FrooxEngine.Slot ChildContainer;
public System.Collections.Generic.List<global::FrooxEngine.FeedItemInterface.NestedItem> NestedItems;
public global::FrooxEngine.IField<global::System.Boolean> EnabledState;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("HasData", HasData.ToResoniteLinkField());
members.Add("ItemName", new ResoniteLink.Reference() { });
members.Add("ItemKey", new ResoniteLink.Reference() { });
members.Add("ItemDescription", new ResoniteLink.Reference() { });
members.Add("HasDescription", new ResoniteLink.Reference() { });
members.Add("DescriptionCleanup", new ResoniteLink.Reference() { });
members.Add("ItemIcon", new ResoniteLink.Reference() { });
members.Add("HasIcon", new ResoniteLink.Reference() { });
members.Add("IconCleanup", new ResoniteLink.Reference() { });
members.Add("View", new ResoniteLink.Reference() { });
members.Add("ParentContainer", new ResoniteLink.Reference() { });
members.Add("ChildContainer", new ResoniteLink.Reference() { });
members.Add("NestedItems", new ResoniteLink.SyncList()
{
    Elements = NestedItems.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("EnabledState", new ResoniteLink.Reference() { });
}

}
}
