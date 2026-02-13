
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyCircleSegmentMesh+MenuSegment
// Generated on: pátek 13. února 2026 23:23:07
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
    public partial class LegacyCircleSegmentMesh
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyCircleSegmentMesh+MenuSegment")]
public partial class MenuSegment : global::FrooxEngine.SyncObject

{
    public global::System.Single RadiusStart;
public global::System.Single Thickness;
public global::System.Single AngleStart;
public global::System.Single ArcLength;
public global::System.Boolean OverrideColor;
public UnityEngine.ColorX FillColor;
public UnityEngine.ColorX OutlineColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("RadiusStart", RadiusStart.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("AngleStart", AngleStart.ToResoniteLinkField());
members.Add("ArcLength", ArcLength.ToResoniteLinkField());
members.Add("OverrideColor", OverrideColor.ToResoniteLinkField());
members.Add("FillColor", FillColor.ToResoniteLinkField());
members.Add("OutlineColor", OutlineColor.ToResoniteLinkField());
}

}
            }
}
