
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldItemInterface
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldItemInterface")]
public partial class WorldItemInterface : global::FrooxEngine.FeedItemInterface

{
    public global::FrooxEngine.IField<global::System.String> WorldName { get => WorldName_Element.Data; set => WorldName_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> WorldName_Element = new();
public global::FrooxEngine.IField<global::System.String> Description { get => Description_Element.Data; set => Description_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> Description_Element = new();
public global::FrooxEngine.IField<System.Uri> ThumbnailUrl { get => ThumbnailUrl_Element.Data; set => ThumbnailUrl_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<System.Uri>>, global::FrooxEngine.IField<System.Uri>> ThumbnailUrl_Element = new();
public global::FrooxEngine.IField<global::System.Int32> JoinedUsers { get => JoinedUsers_Element.Data; set => JoinedUsers_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> JoinedUsers_Element = new();
public global::FrooxEngine.IField<global::System.Int32> ActiveUsers { get => ActiveUsers_Element.Data; set => ActiveUsers_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> ActiveUsers_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> IsHost { get => IsHost_Element.Data; set => IsHost_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> IsHost_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> AwayKickEnabled { get => AwayKickEnabled_Element.Data; set => AwayKickEnabled_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> AwayKickEnabled_Element = new();
public global::FrooxEngine.IField<global::System.TimeSpan> AwayKickInterval { get => AwayKickInterval_Element.Data; set => AwayKickInterval_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.TimeSpan>>, global::FrooxEngine.IField<global::System.TimeSpan>> AwayKickInterval_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("WorldName", WorldName_Element.ToLinkReference(context));
members.Add("Description", Description_Element.ToLinkReference(context));
members.Add("ThumbnailUrl", ThumbnailUrl_Element.ToLinkReference(context));
members.Add("JoinedUsers", JoinedUsers_Element.ToLinkReference(context));
members.Add("ActiveUsers", ActiveUsers_Element.ToLinkReference(context));
members.Add("IsHost", IsHost_Element.ToLinkReference(context));
members.Add("AwayKickEnabled", AwayKickEnabled_Element.ToLinkReference(context));
members.Add("AwayKickInterval", AwayKickInterval_Element.ToLinkReference(context));
}

}
}
