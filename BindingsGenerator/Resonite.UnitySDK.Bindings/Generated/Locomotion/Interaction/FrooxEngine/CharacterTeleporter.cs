
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterTeleporter
// Generated on: čtvrtek 26. února 2026 10:03:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterTeleporter")]
public partial class CharacterTeleporter : global::FrooxEngine.CollisionListenerComponent

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.CharacterTeleporter.Exit>, global::FrooxEngine.CharacterTeleporter.Exit> Exits = new();
public global::System.Single MinimumVelocity { get => MinimumVelocity_Element.Data; set => MinimumVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinimumVelocity_Element = new();
public UnityEngine.Vector3 DirectionReference { get => DirectionReference_Element.Data; set => DirectionReference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> DirectionReference_Element = new();
public global::System.Single MaxDirectionAngle { get => MaxDirectionAngle_Element.Data; set => MaxDirectionAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxDirectionAngle_Element = new();
public global::System.Boolean IgnoreParentUser { get => IgnoreParentUser_Element.Data; set => IgnoreParentUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreParentUser_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Exits", new ResoniteLink.SyncList()
{
    Elements = Exits.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("MinimumVelocity", MinimumVelocity_Element.Data.ToResoniteLinkField());
members.Add("DirectionReference", DirectionReference_Element.Data.ToResoniteLinkField());
members.Add("MaxDirectionAngle", MaxDirectionAngle_Element.Data.ToResoniteLinkField());
members.Add("IgnoreParentUser", IgnoreParentUser_Element.Data.ToResoniteLinkField());
}

}
}
