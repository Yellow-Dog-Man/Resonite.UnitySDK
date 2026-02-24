
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserPositioner
// Generated on: úterý 24. února 2026 18:20:18
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserPositioner")]
public partial class AvatarUserPositioner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.UserRoot.UserNode PositionNode;
public global::FrooxEngine.UserRoot.UserNode RotationNode;
public global::FrooxEngine.Slot PositionReference;
public global::FrooxEngine.Slot RotationReference;
public global::System.Boolean PreserveUp;
public global::System.Boolean OnManualEquipOnly;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionNode", PositionNode.ToResoniteLinkField());
members.Add("RotationNode", RotationNode.ToResoniteLinkField());
members.Add("PositionReference", PositionReference.ToResoniteReference(context));
members.Add("RotationReference", RotationReference.ToResoniteReference(context));
members.Add("PreserveUp", PreserveUp.ToResoniteLinkField());
members.Add("OnManualEquipOnly", OnManualEquipOnly.ToResoniteLinkField());
}

}
}
