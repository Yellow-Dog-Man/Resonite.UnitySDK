
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterParenter
// Generated on: úterý 24. února 2026 18:17:50
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::System.Boolean NestIntoSpace;
public global::System.Boolean MustBeOnGround;
public System.Collections.Generic.List<global::FrooxEngine.CharacterParenter.AlignmentFilter> Filters;
public global::System.Boolean IgnoreParentUser;
public global::FrooxEngine.RootSpace ParentSpace;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NestIntoSpace", NestIntoSpace.ToResoniteLinkField());
members.Add("MustBeOnGround", MustBeOnGround.ToResoniteLinkField());
members.Add("Filters", new ResoniteLink.SyncList()
{
    Elements = Filters.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("IgnoreParentUser", IgnoreParentUser.ToResoniteLinkField());
members.Add("ParentSpace", new ResoniteLink.SyncObject() { Members = ParentSpace.CollectMembers(context) });
}

}
}
