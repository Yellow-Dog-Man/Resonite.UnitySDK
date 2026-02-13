
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Slider+SnapPosition
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
    public partial class Slider
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Slider+SnapPosition")]
public partial class SnapPosition : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Position;
public global::System.Single MaxDistance;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Position", Position.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
}

}
            }
}
