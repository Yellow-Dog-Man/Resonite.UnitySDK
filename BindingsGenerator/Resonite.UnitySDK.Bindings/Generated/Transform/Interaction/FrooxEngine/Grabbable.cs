
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Grabbable
// Generated on: čtvrtek 26. února 2026 15:09:08
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Grabbable")]
public partial class Grabbable : global::FrooxEngine.Component, global::FrooxEngine.IGrabbable, global::FrooxEngine.IInteractionTarget, global::FrooxEngine.IObjectRoot

{
    public global::System.Boolean ReparentOnRelease { get => ReparentOnRelease_Element.Data; set => ReparentOnRelease_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ReparentOnRelease_Element = new();
public global::System.Boolean PreserveUserSpace { get => PreserveUserSpace_Element.Data; set => PreserveUserSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreserveUserSpace_Element = new();
public global::System.Boolean DestroyOnRelease { get => DestroyOnRelease_Element.Data; set => DestroyOnRelease_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DestroyOnRelease_Element = new();
public global::System.Int32 GrabPriority { get => GrabPriority_Element.Data; set => GrabPriority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> GrabPriority_Element = new();
public global::System.Nullable<global::System.Int32> GrabPriorityWhenGrabbed { get => GrabPriorityWhenGrabbed_Element.Data; set => GrabPriorityWhenGrabbed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Int32>>, global::System.Nullable<global::System.Int32>> GrabPriorityWhenGrabbed_Element = new();
public global::System.Boolean EditModeOnly { get => EditModeOnly_Element.Data; set => EditModeOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EditModeOnly_Element = new();
public global::System.Boolean AllowSteal { get => AllowSteal_Element.Data; set => AllowSteal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowSteal_Element = new();
public global::System.Boolean DropOnDisable { get => DropOnDisable_Element.Data; set => DropOnDisable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DropOnDisable_Element = new();
public global::FrooxEngine.ActiveUserHandling ActiveUserFilter { get => ActiveUserFilter_Element.Data; set => ActiveUserFilter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ActiveUserHandling>, global::FrooxEngine.ActiveUserHandling> ActiveUserFilter_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UserRef>, global::FrooxEngine.UserRef> OnlyUsers = new();
public global::System.Boolean Scalable { get => Scalable_Element.Data; set => Scalable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Scalable_Element = new();
public global::System.Boolean Receivable { get => Receivable_Element.Data; set => Receivable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Receivable_Element = new();
public global::System.Boolean AllowOnlyPhysicalGrab { get => AllowOnlyPhysicalGrab_Element.Data; set => AllowOnlyPhysicalGrab_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowOnlyPhysicalGrab_Element = new();
public global::FrooxEngine.Grabber _grabber { get => _grabber_Element.Data; set => _grabber_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Grabber>, global::FrooxEngine.Grabber> _grabber_Element = new();
public global::FrooxEngine.Slot _lastParent { get => _lastParent_Element.Data; set => _lastParent_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _lastParent_Element = new();
public global::System.Boolean _lastParentIsUserSpace { get => _lastParentIsUserSpace_Element.Data; set => _lastParentIsUserSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _lastParentIsUserSpace_Element = new();
public global::System.Boolean __legacyActiveUserRootOnly { get => __legacyActiveUserRootOnly_Element.Data; set => __legacyActiveUserRootOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> __legacyActiveUserRootOnly_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReparentOnRelease", ReparentOnRelease_Element.ToLinkField(context));
members.Add("PreserveUserSpace", PreserveUserSpace_Element.ToLinkField(context));
members.Add("DestroyOnRelease", DestroyOnRelease_Element.ToLinkField(context));
members.Add("GrabPriority", GrabPriority_Element.ToLinkField(context));
members.Add("GrabPriorityWhenGrabbed", GrabPriorityWhenGrabbed_Element.ToLinkField(context));
members.Add("EditModeOnly", EditModeOnly_Element.ToLinkField(context));
members.Add("AllowSteal", AllowSteal_Element.ToLinkField(context));
members.Add("DropOnDisable", DropOnDisable_Element.ToLinkField(context));
members.Add("ActiveUserFilter", ActiveUserFilter_Element.ToLinkField(context));
members.Add("OnlyUsers", OnlyUsers.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("Scalable", Scalable_Element.ToLinkField(context));
members.Add("Receivable", Receivable_Element.ToLinkField(context));
members.Add("AllowOnlyPhysicalGrab", AllowOnlyPhysicalGrab_Element.ToLinkField(context));
members.Add("_grabber", _grabber_Element.ToLinkReference(context));
members.Add("_lastParent", _lastParent_Element.ToLinkReference(context));
members.Add("_lastParentIsUserSpace", _lastParentIsUserSpace_Element.ToLinkField(context));
members.Add("__legacyActiveUserRootOnly", __legacyActiveUserRootOnly_Element.ToLinkField(context));
}

}
}
