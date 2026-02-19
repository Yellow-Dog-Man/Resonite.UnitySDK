
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterColliderWorldLink
// Generated on: čtvrtek 19. února 2026 8:00:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterColliderWorldLink")]
public partial class CharacterColliderWorldLink : global::FrooxEngine.CollisionListenerComponent

{
    public global::System.Boolean OpenOnContactStart;
public global::System.Boolean OpenOnContactStay;
public global::System.Boolean OpenOnContactEnd;
public global::FrooxEngine.WorldLink WorldLink;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OpenOnContactStart", OpenOnContactStart.ToResoniteLinkField());
members.Add("OpenOnContactStay", OpenOnContactStay.ToResoniteLinkField());
members.Add("OpenOnContactEnd", OpenOnContactEnd.ToResoniteLinkField());
members.Add("WorldLink", WorldLink.ToResoniteReference(context));
}

}
}
