
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MergedWorldDataItemInterface
// Generated on: čtvrtek 26. února 2026 10:04:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MergedWorldDataItemInterface")]
public partial class MergedWorldDataItemInterface : global::FrooxEngine.FeedItemInterface

{
    public global::FrooxEngine.IField<global::System.Boolean> IsMerged { get => IsMerged_Element.Data; set => IsMerged_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> IsMerged_Element = new();
public global::FrooxEngine.IField<global::System.Int32> SessionCount { get => SessionCount_Element.Data; set => SessionCount_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> SessionCount_Element = new();
public global::FrooxEngine.IField<global::System.Int32> WorldCount { get => WorldCount_Element.Data; set => WorldCount_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> WorldCount_Element = new();
public global::FrooxEngine.IField<global::System.String> MainName { get => MainName_Element.Data; set => MainName_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> MainName_Element = new();
public global::FrooxEngine.IField<System.Uri> MainThumbnail { get => MainThumbnail_Element.Data; set => MainThumbnail_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<System.Uri>>, global::FrooxEngine.IField<System.Uri>> MainThumbnail_Element = new();
public global::FrooxEngine.IField<global::System.String> WorldOrSessionId { get => WorldOrSessionId_Element.Data; set => WorldOrSessionId_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> WorldOrSessionId_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalAggregateActiveUsers { get => TotalAggregateActiveUsers_Element.Data; set => TotalAggregateActiveUsers_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalAggregateActiveUsers_Element = new();
public global::FrooxEngine.IField<global::System.Int32> TotalAggregateContacts { get => TotalAggregateContacts_Element.Data; set => TotalAggregateContacts_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> TotalAggregateContacts_Element = new();
public global::FrooxEngine.FeedSubTemplate<global::FrooxEngine.DataFeedEntity<global::SkyFrost.Base.SessionInfo>,global::FrooxEngine.SessionInfoItemInterface> Sessions = new();
public global::FrooxEngine.FeedSubTemplate<global::FrooxEngine.DataFeedEntity<global::FrooxEngine.World>,global::FrooxEngine.WorldItemInterface> Worlds = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsMerged", IsMerged_Element.Data.ToResoniteReference(context));
members.Add("SessionCount", SessionCount_Element.Data.ToResoniteReference(context));
members.Add("WorldCount", WorldCount_Element.Data.ToResoniteReference(context));
members.Add("MainName", MainName_Element.Data.ToResoniteReference(context));
members.Add("MainThumbnail", MainThumbnail_Element.Data.ToResoniteReference(context));
members.Add("WorldOrSessionId", WorldOrSessionId_Element.Data.ToResoniteReference(context));
members.Add("TotalAggregateActiveUsers", TotalAggregateActiveUsers_Element.Data.ToResoniteReference(context));
members.Add("TotalAggregateContacts", TotalAggregateContacts_Element.Data.ToResoniteReference(context));
members.Add("Sessions", new ResoniteLink.SyncObject() { Members = Sessions.CollectMembers(context) });
members.Add("Worlds", new ResoniteLink.SyncObject() { Members = Worlds.CollectMembers(context) });
}

}
}
