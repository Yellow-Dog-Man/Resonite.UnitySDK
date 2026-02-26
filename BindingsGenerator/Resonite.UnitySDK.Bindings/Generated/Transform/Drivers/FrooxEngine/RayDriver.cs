
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RayDriver
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RayDriver")]
public partial class RayDriver : global::FrooxEngine.Component

{
    public global::System.Single MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxDistance_Element = new();
public global::FrooxEngine.Sync<UnityEngine.Vector3> PointA { get => PointA_Element.Data; set => PointA_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.Sync<UnityEngine.Vector3>>, global::FrooxEngine.Sync<UnityEngine.Vector3>> PointA_Element = new();
public global::FrooxEngine.Sync<UnityEngine.Vector3> PointB { get => PointB_Element.Data; set => PointB_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.Sync<UnityEngine.Vector3>>, global::FrooxEngine.Sync<UnityEngine.Vector3>> PointB_Element = new();
public UnityEngine.Vector3 LocalOrigin { get => LocalOrigin_Element.Data; set => LocalOrigin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalOrigin_Element = new();
public UnityEngine.Vector3 LocalDirection { get => LocalDirection_Element.Data; set => LocalDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalDirection_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxDistance", MaxDistance_Element.Data.ToResoniteLinkField());
members.Add("PointA", PointA_Element.Data.ToResoniteReference(context));
members.Add("PointB", PointB_Element.Data.ToResoniteReference(context));
members.Add("LocalOrigin", LocalOrigin_Element.Data.ToResoniteLinkField());
members.Add("LocalDirection", LocalDirection_Element.Data.ToResoniteLinkField());
}

}
}
