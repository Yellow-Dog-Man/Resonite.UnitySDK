
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Joint+SnapOrientation
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
    public partial class Joint
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Joint+SnapOrientation")]
public partial class SnapOrientation : global::FrooxEngine.SyncObject

{
    public UnityEngine.Quaternion Orientation { get => Orientation_Element.Data; set => Orientation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> Orientation_Element = new();
public global::System.Single MaxAngle { get => MaxAngle_Element.Data; set => MaxAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxAngle_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Orientation", Orientation_Element.Data.ToResoniteLinkField());
members.Add("MaxAngle", MaxAngle_Element.Data.ToResoniteLinkField());
}

}
            }
}
