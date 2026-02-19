
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterTeleporter
// Generated on: čtvrtek 19. února 2026 7:58:59
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterTeleporter")]
public partial class CharacterTeleporter : global::FrooxEngine.CollisionListenerComponent

{
    public System.Collections.Generic.List<global::FrooxEngine.CharacterTeleporter.Exit> Exits;
public global::System.Single MinimumVelocity;
public UnityEngine.Vector3 DirectionReference;
public global::System.Single MaxDirectionAngle;
public global::System.Boolean IgnoreParentUser;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Exits", new ResoniteLink.SyncList()
{
    Elements = Exits.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("MinimumVelocity", MinimumVelocity.ToResoniteLinkField());
members.Add("DirectionReference", DirectionReference.ToResoniteLinkField());
members.Add("MaxDirectionAngle", MaxDirectionAngle.ToResoniteLinkField());
members.Add("IgnoreParentUser", IgnoreParentUser.ToResoniteLinkField());
}

}
}
