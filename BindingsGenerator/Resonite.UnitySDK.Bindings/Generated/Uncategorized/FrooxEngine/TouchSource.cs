
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchSource
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchSource")]
public abstract partial class TouchSource : global::FrooxEngine.Component

{
    public global::FrooxEngine.User AutoUpdateUser { get => AutoUpdateUser_Element.Data; set => AutoUpdateUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> AutoUpdateUser_Element = new();
public global::System.Single OutOfSightAngle { get => OutOfSightAngle_Element.Data; set => OutOfSightAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OutOfSightAngle_Element = new();
public global::System.Single MaxTouchPenetrationDistance { get => MaxTouchPenetrationDistance_Element.Data; set => MaxTouchPenetrationDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxTouchPenetrationDistance_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AutoUpdateUser", AutoUpdateUser_Element.ToLinkReference(context));
members.Add("OutOfSightAngle", OutOfSightAngle_Element.ToLinkField(context));
members.Add("MaxTouchPenetrationDistance", MaxTouchPenetrationDistance_Element.ToLinkField(context));
}

}
}
