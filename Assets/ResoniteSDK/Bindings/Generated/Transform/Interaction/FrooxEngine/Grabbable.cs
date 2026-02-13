
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Grabbable
// Generated on: pátek 13. února 2026 5:52:27
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Grabbable")]
public partial class Grabbable : global::FrooxEngine.Component, global::FrooxEngine.IGrabbable, global::FrooxEngine.IInteractionTarget, global::FrooxEngine.IObjectRoot

{
    public global::System.Boolean ReparentOnRelease;
public global::System.Boolean PreserveUserSpace;
public global::System.Boolean DestroyOnRelease;
public global::System.Int32 GrabPriority;
public global::System.Nullable<global::System.Int32> GrabPriorityWhenGrabbed;
public global::System.Boolean EditModeOnly;
public global::System.Boolean AllowSteal;
public global::System.Boolean DropOnDisable;
public global::FrooxEngine.ActiveUserHandling ActiveUserFilter;
public System.Collections.Generic.List<global::FrooxEngine.UserRef> OnlyUsers;
public global::System.Boolean Scalable;
public global::System.Boolean Receivable;
public global::System.Boolean AllowOnlyPhysicalGrab;
public global::FrooxEngine.Grabber _grabber;
public global::FrooxEngine.Slot _lastParent;
public global::System.Boolean _lastParentIsUserSpace;
public global::System.Boolean __legacyActiveUserRootOnly;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ReparentOnRelease", ReparentOnRelease.ToResoniteLinkField());
members.Add("PreserveUserSpace", PreserveUserSpace.ToResoniteLinkField());
members.Add("DestroyOnRelease", DestroyOnRelease.ToResoniteLinkField());
members.Add("GrabPriority", GrabPriority.ToResoniteLinkField());
members.Add("GrabPriorityWhenGrabbed", GrabPriorityWhenGrabbed.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
members.Add("AllowSteal", AllowSteal.ToResoniteLinkField());
members.Add("DropOnDisable", DropOnDisable.ToResoniteLinkField());
members.Add("ActiveUserFilter", ActiveUserFilter.ToResoniteLinkField());
members.Add("OnlyUsers", new ResoniteLink.SyncList()
{
    Elements = OnlyUsers.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("Scalable", Scalable.ToResoniteLinkField());
members.Add("Receivable", Receivable.ToResoniteLinkField());
members.Add("AllowOnlyPhysicalGrab", AllowOnlyPhysicalGrab.ToResoniteLinkField());
members.Add("_grabber", new ResoniteLink.Reference() { });
members.Add("_lastParent", new ResoniteLink.Reference() { });
members.Add("_lastParentIsUserSpace", _lastParentIsUserSpace.ToResoniteLinkField());
members.Add("__legacyActiveUserRootOnly", __legacyActiveUserRootOnly.ToResoniteLinkField());
}

}
}
