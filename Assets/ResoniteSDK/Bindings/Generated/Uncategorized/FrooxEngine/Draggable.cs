
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Draggable
// Generated on: pátek 13. února 2026 23:23:10
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
members.Add("AllowSteal", AllowSteal.ToResoniteLinkField());
members.Add("DropOnDisable", DropOnDisable.ToResoniteLinkField());
members.Add("DontDrive", DontDrive.ToResoniteLinkField());
members.Add("AllowOnlyPhysicalGrab", AllowOnlyPhysicalGrab.ToResoniteLinkField());
members.Add("ActiveUserFilter", ActiveUserFilter.ToResoniteLinkField());
members.Add("_grabber", new ResoniteLink.Reference() { });
members.Add("_holdSlot", new ResoniteLink.Reference() { });
members.Add("_pos", new ResoniteLink.Reference() { });
members.Add("_rot", new ResoniteLink.Reference() { });
members.Add("_scl", new ResoniteLink.Reference() { });
members.Add("__legacyActiveUserRootOnly", __legacyActiveUserRootOnly.ToResoniteLinkField());
members.Add("GrabPriority", GrabPriority.ToResoniteLinkField());
}

}
}
