
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterTeleporter
// Generated on: pátek 13. února 2026 5:51:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterTeleporter")]
public partial class CharacterTeleporter : global::FrooxEngine.CollisionListenerComponent

{
    public System.Collections.Generic.List<global::FrooxEngine.CharacterTeleporter.Exit> Exits;
public global::System.Single MinimumVelocity;
public UnityEngine.Vector3 DirectionReference;
public global::System.Single MaxDirectionAngle;
public global::System.Boolean IgnoreParentUser;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Exits", new ResoniteLink.SyncList()
{
    Elements = Exits.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("MinimumVelocity", MinimumVelocity.ToResoniteLinkField());
members.Add("DirectionReference", DirectionReference.ToResoniteLinkField());
members.Add("MaxDirectionAngle", MaxDirectionAngle.ToResoniteLinkField());
members.Add("IgnoreParentUser", IgnoreParentUser.ToResoniteLinkField());
}

}
}
