
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserPositioner
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.UserRoot.UserNode PositionNode { get => PositionNode_Element.Data; set => PositionNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> PositionNode_Element = new();
public global::FrooxEngine.UserRoot.UserNode RotationNode { get => RotationNode_Element.Data; set => RotationNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> RotationNode_Element = new();
public global::FrooxEngine.Slot PositionReference { get => PositionReference_Element.Data; set => PositionReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> PositionReference_Element = new();
public global::FrooxEngine.Slot RotationReference { get => RotationReference_Element.Data; set => RotationReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> RotationReference_Element = new();
public global::System.Boolean PreserveUp { get => PreserveUp_Element.Data; set => PreserveUp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreserveUp_Element = new();
public global::System.Boolean OnManualEquipOnly { get => OnManualEquipOnly_Element.Data; set => OnManualEquipOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OnManualEquipOnly_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionNode", PositionNode_Element.ToLinkField(context));
members.Add("RotationNode", RotationNode_Element.ToLinkField(context));
members.Add("PositionReference", PositionReference_Element.ToLinkReference(context));
members.Add("RotationReference", RotationReference_Element.ToLinkReference(context));
members.Add("PreserveUp", PreserveUp_Element.ToLinkField(context));
members.Add("OnManualEquipOnly", OnManualEquipOnly_Element.ToLinkField(context));
}

}
}
