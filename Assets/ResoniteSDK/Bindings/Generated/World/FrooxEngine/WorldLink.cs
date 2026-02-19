
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldLink
// Generated on: čtvrtek 19. února 2026 7:58:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldLink")]
public partial class WorldLink : global::FrooxEngine.Component, global::FrooxEngine.IWorldLink

{
    public System.Uri URL;
public System.Collections.Generic.List<System.Uri> ActiveSessionURLs;
public global::FrooxEngine.Userspace.WorldRelation WorldRelation;
public global::System.Boolean AutoFocus;
public global::System.Boolean GetExisting;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL.ToResoniteLinkField());
members.Add("ActiveSessionURLs", new ResoniteLink.SyncList()
{
    Elements = ActiveSessionURLs.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("WorldRelation", WorldRelation.ToResoniteLinkField());
members.Add("AutoFocus", AutoFocus.ToResoniteLinkField());
members.Add("GetExisting", GetExisting.ToResoniteLinkField());
}

}
}
