
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Joint+SnapOrientation
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
    public partial class Joint
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Joint+SnapOrientation")]
public partial class SnapOrientation : global::FrooxEngine.SyncObject

{
    public UnityEngine.Quaternion Orientation;
public global::System.Single MaxAngle;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Orientation", Orientation.ToResoniteLinkField());
members.Add("MaxAngle", MaxAngle.ToResoniteLinkField());
}

}
            }
}
