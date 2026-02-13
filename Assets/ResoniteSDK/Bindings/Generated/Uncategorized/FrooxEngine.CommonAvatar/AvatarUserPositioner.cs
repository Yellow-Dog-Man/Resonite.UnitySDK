
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserPositioner
// Generated on: pátek 13. února 2026 23:23:12
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PositionNode", PositionNode.ToResoniteLinkField());
members.Add("RotationNode", RotationNode.ToResoniteLinkField());
members.Add("PositionReference", new ResoniteLink.Reference() { });
members.Add("RotationReference", new ResoniteLink.Reference() { });
members.Add("PreserveUp", PreserveUp.ToResoniteLinkField());
members.Add("OnManualEquipOnly", OnManualEquipOnly.ToResoniteLinkField());
}

}
}
