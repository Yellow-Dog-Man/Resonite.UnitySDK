
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiSegmentMesh+SegmentInfo
// Generated on: středa 25. února 2026 16:13:04
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
    public partial class MultiSegmentMesh
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiSegmentMesh+SegmentInfo")]
public partial class SegmentInfo : global::FrooxEngine.SyncObject

{
    public global::System.Single Radius;
public UnityEngine.Vector3 PointA;
public UnityEngine.Vector3 PointB;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("PointA", PointA.ToResoniteLinkField());
members.Add("PointB", PointB.ToResoniteLinkField());
}

}
            }
}
