
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterColliderWorldLink
// Generated on: středa 25. února 2026 16:14:47
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
