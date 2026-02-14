
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Draggable
// Generated on: sobota 14. února 2026 8:58:40
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Draggable")]
public abstract partial class Draggable : global::FrooxEngine.Component, global::FrooxEngine.IGrabbable, global::FrooxEngine.IInteractionTarget

{
    public global::System.Boolean EditModeOnly;
public global::System.Boolean AllowSteal;
public global::System.Boolean DropOnDisable;
public global::System.Boolean DontDrive;
public global::System.Boolean AllowOnlyPhysicalGrab;
public global::FrooxEngine.ActiveUserHandling ActiveUserFilter;
public global::FrooxEngine.Grabber _grabber;
public global::FrooxEngine.Slot _holdSlot;
public global::FrooxEngine.Sync<UnityEngine.Vector3> _pos;
public global::FrooxEngine.Sync<UnityEngine.Quaternion> _rot;
public global::FrooxEngine.Sync<UnityEngine.Vector3> _scl;
public global::System.Boolean __legacyActiveUserRootOnly;
public global::System.Int32 GrabPriority;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
members.Add("AllowSteal", AllowSteal.ToResoniteLinkField());
members.Add("DropOnDisable", DropOnDisable.ToResoniteLinkField());
members.Add("DontDrive", DontDrive.ToResoniteLinkField());
members.Add("AllowOnlyPhysicalGrab", AllowOnlyPhysicalGrab.ToResoniteLinkField());
members.Add("ActiveUserFilter", ActiveUserFilter.ToResoniteLinkField());
members.Add("_grabber", _grabber.ToResoniteReference(context));
members.Add("_holdSlot", _holdSlot.ToResoniteReference(context));
members.Add("_pos", _pos.ToResoniteReference(context));
members.Add("_rot", _rot.ToResoniteReference(context));
members.Add("_scl", _scl.ToResoniteReference(context));
members.Add("__legacyActiveUserRootOnly", __legacyActiveUserRootOnly.ToResoniteLinkField());
members.Add("GrabPriority", GrabPriority.ToResoniteLinkField());
}

}
}
