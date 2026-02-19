
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedItemInterface
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HasData", HasData.ToResoniteLinkField());
members.Add("ItemName", ItemName.ToResoniteReference(context));
members.Add("ItemKey", ItemKey.ToResoniteReference(context));
members.Add("ItemDescription", ItemDescription.ToResoniteReference(context));
members.Add("HasDescription", HasDescription.ToResoniteReference(context));
members.Add("DescriptionCleanup", DescriptionCleanup.ToResoniteReference(context));
members.Add("ItemIcon", ItemIcon.ToResoniteReference(context));
members.Add("HasIcon", HasIcon.ToResoniteReference(context));
members.Add("IconCleanup", IconCleanup.ToResoniteReference(context));
members.Add("View", View.ToResoniteReference(context));
members.Add("ParentContainer", ParentContainer.ToResoniteReference(context));
members.Add("ChildContainer", ChildContainer.ToResoniteReference(context));
members.Add("NestedItems", new ResoniteLink.SyncList()
{
    Elements = NestedItems.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("EnabledState", EnabledState.ToResoniteReference(context));
}

}
}
