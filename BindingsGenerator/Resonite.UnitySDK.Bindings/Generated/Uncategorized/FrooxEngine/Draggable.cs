
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Draggable
// Generated on: čtvrtek 26. února 2026 10:04:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Draggable")]
public abstract partial class Draggable : global::FrooxEngine.Component, global::FrooxEngine.IGrabbable, global::FrooxEngine.IInteractionTarget

{
    public global::System.Boolean EditModeOnly { get => EditModeOnly_Element.Data; set => EditModeOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EditModeOnly_Element = new();
public global::System.Boolean AllowSteal { get => AllowSteal_Element.Data; set => AllowSteal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowSteal_Element = new();
public global::System.Boolean DropOnDisable { get => DropOnDisable_Element.Data; set => DropOnDisable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DropOnDisable_Element = new();
public global::System.Boolean DontDrive { get => DontDrive_Element.Data; set => DontDrive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DontDrive_Element = new();
public global::System.Boolean AllowOnlyPhysicalGrab { get => AllowOnlyPhysicalGrab_Element.Data; set => AllowOnlyPhysicalGrab_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowOnlyPhysicalGrab_Element = new();
public global::FrooxEngine.ActiveUserHandling ActiveUserFilter { get => ActiveUserFilter_Element.Data; set => ActiveUserFilter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ActiveUserHandling>, global::FrooxEngine.ActiveUserHandling> ActiveUserFilter_Element = new();
public global::FrooxEngine.Grabber _grabber { get => _grabber_Element.Data; set => _grabber_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Grabber>, global::FrooxEngine.Grabber> _grabber_Element = new();
public global::FrooxEngine.Slot _holdSlot { get => _holdSlot_Element.Data; set => _holdSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _holdSlot_Element = new();
public global::FrooxEngine.Sync<UnityEngine.Vector3> _pos { get => _pos_Element.Data; set => _pos_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.Sync<UnityEngine.Vector3>>, global::FrooxEngine.Sync<UnityEngine.Vector3>> _pos_Element = new();
public global::FrooxEngine.Sync<UnityEngine.Quaternion> _rot { get => _rot_Element.Data; set => _rot_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.Sync<UnityEngine.Quaternion>>, global::FrooxEngine.Sync<UnityEngine.Quaternion>> _rot_Element = new();
public global::FrooxEngine.Sync<UnityEngine.Vector3> _scl { get => _scl_Element.Data; set => _scl_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.Sync<UnityEngine.Vector3>>, global::FrooxEngine.Sync<UnityEngine.Vector3>> _scl_Element = new();
public global::System.Boolean __legacyActiveUserRootOnly { get => __legacyActiveUserRootOnly_Element.Data; set => __legacyActiveUserRootOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> __legacyActiveUserRootOnly_Element = new();
public global::System.Int32 GrabPriority { get => GrabPriority_Element.Data; set => GrabPriority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> GrabPriority_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EditModeOnly", EditModeOnly_Element.Data.ToResoniteLinkField());
members.Add("AllowSteal", AllowSteal_Element.Data.ToResoniteLinkField());
members.Add("DropOnDisable", DropOnDisable_Element.Data.ToResoniteLinkField());
members.Add("DontDrive", DontDrive_Element.Data.ToResoniteLinkField());
members.Add("AllowOnlyPhysicalGrab", AllowOnlyPhysicalGrab_Element.Data.ToResoniteLinkField());
members.Add("ActiveUserFilter", ActiveUserFilter_Element.Data.ToResoniteLinkField());
members.Add("_grabber", _grabber_Element.Data.ToResoniteReference(context));
members.Add("_holdSlot", _holdSlot_Element.Data.ToResoniteReference(context));
members.Add("_pos", _pos_Element.Data.ToResoniteReference(context));
members.Add("_rot", _rot_Element.Data.ToResoniteReference(context));
members.Add("_scl", _scl_Element.Data.ToResoniteReference(context));
members.Add("__legacyActiveUserRootOnly", __legacyActiveUserRootOnly_Element.Data.ToResoniteLinkField());
members.Add("GrabPriority", GrabPriority_Element.Data.ToResoniteLinkField());
}

}
}
