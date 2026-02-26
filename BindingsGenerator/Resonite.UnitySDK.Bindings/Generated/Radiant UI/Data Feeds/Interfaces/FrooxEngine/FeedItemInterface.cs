
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedItemInterface
// Generated on: čtvrtek 26. února 2026 12:28:01
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedItemInterface")]
public partial class FeedItemInterface : global::FrooxEngine.Component

{
    public global::System.Boolean HasData { get => HasData_Element.Data; set => HasData_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HasData_Element = new();
public global::FrooxEngine.IField<global::System.String> ItemName { get => ItemName_Element.Data; set => ItemName_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> ItemName_Element = new();
public global::FrooxEngine.IField<global::System.String> ItemKey { get => ItemKey_Element.Data; set => ItemKey_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> ItemKey_Element = new();
public global::FrooxEngine.IField<global::System.String> ItemDescription { get => ItemDescription_Element.Data; set => ItemDescription_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> ItemDescription_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HasDescription { get => HasDescription_Element.Data; set => HasDescription_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> HasDescription_Element = new();
public global::FrooxEngine.Slot DescriptionCleanup { get => DescriptionCleanup_Element.Data; set => DescriptionCleanup_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> DescriptionCleanup_Element = new();
public global::FrooxEngine.IField<System.Uri> ItemIcon { get => ItemIcon_Element.Data; set => ItemIcon_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<System.Uri>>, global::FrooxEngine.IField<System.Uri>> ItemIcon_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> HasIcon { get => HasIcon_Element.Data; set => HasIcon_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> HasIcon_Element = new();
public global::FrooxEngine.Slot IconCleanup { get => IconCleanup_Element.Data; set => IconCleanup_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> IconCleanup_Element = new();
public global::FrooxEngine.SyncRef<global::FrooxEngine.IDataFeedView> View { get => View_Element.Data; set => View_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.IDataFeedView>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IDataFeedView>> View_Element = new();
public global::FrooxEngine.FeedItemInterface ParentContainer { get => ParentContainer_Element.Data; set => ParentContainer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FeedItemInterface>, global::FrooxEngine.FeedItemInterface> ParentContainer_Element = new();
public global::FrooxEngine.Slot ChildContainer { get => ChildContainer_Element.Data; set => ChildContainer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ChildContainer_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.FeedItemInterface.NestedItem>, global::FrooxEngine.FeedItemInterface.NestedItem> NestedItems = new();
public global::FrooxEngine.IField<global::System.Boolean> EnabledState { get => EnabledState_Element.Data; set => EnabledState_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> EnabledState_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HasData", HasData_Element.ToLinkField(context));
members.Add("ItemName", ItemName_Element.ToLinkReference(context));
members.Add("ItemKey", ItemKey_Element.ToLinkReference(context));
members.Add("ItemDescription", ItemDescription_Element.ToLinkReference(context));
members.Add("HasDescription", HasDescription_Element.ToLinkReference(context));
members.Add("DescriptionCleanup", DescriptionCleanup_Element.ToLinkReference(context));
members.Add("ItemIcon", ItemIcon_Element.ToLinkReference(context));
members.Add("HasIcon", HasIcon_Element.ToLinkReference(context));
members.Add("IconCleanup", IconCleanup_Element.ToLinkReference(context));
members.Add("View", View_Element.ToLinkReference(context));
members.Add("ParentContainer", ParentContainer_Element.ToLinkReference(context));
members.Add("ChildContainer", ChildContainer_Element.ToLinkReference(context));
members.Add("NestedItems", NestedItems.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("EnabledState", EnabledState_Element.ToLinkReference(context));
}

}
}
