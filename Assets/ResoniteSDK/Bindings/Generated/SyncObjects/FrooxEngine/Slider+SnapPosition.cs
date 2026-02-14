
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Slider+SnapPosition
// Generated on: sobota 14. února 2026 8:58:40
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
}

}
            }
}
