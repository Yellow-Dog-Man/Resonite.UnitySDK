
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Joint+SnapOrientation
// Generated on: úterý 24. února 2026 18:20:15
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public UnityEngine.Quaternion Orientation;
public global::System.Single MaxAngle;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Orientation", Orientation.ToResoniteLinkField());
members.Add("MaxAngle", MaxAngle.ToResoniteLinkField());
}

}
            }
}
