
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterParenter
// Generated on: čtvrtek 26. února 2026 12:26:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterParenter")]
public partial class CharacterParenter : global::FrooxEngine.CollisionListenerComponent

{
    public global::System.Boolean NestIntoSpace { get => NestIntoSpace_Element.Data; set => NestIntoSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> NestIntoSpace_Element = new();
public global::System.Boolean MustBeOnGround { get => MustBeOnGround_Element.Data; set => MustBeOnGround_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MustBeOnGround_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CharacterParenter.AlignmentFilter>, global::FrooxEngine.CharacterParenter.AlignmentFilter> Filters = new();
public global::System.Boolean IgnoreParentUser { get => IgnoreParentUser_Element.Data; set => IgnoreParentUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreParentUser_Element = new();
public global::FrooxEngine.RootSpace ParentSpace = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NestIntoSpace", NestIntoSpace_Element.ToLinkField(context));
members.Add("MustBeOnGround", MustBeOnGround_Element.ToLinkField(context));
members.Add("Filters", Filters.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("IgnoreParentUser", IgnoreParentUser_Element.ToLinkField(context));
members.Add("ParentSpace", ParentSpace.ToLinkSyncObject(context));
}

}
}
