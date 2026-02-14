
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightningMesh+StrikeProperties
// Generated on: sobota 14. února 2026 8:57:00
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
    public partial class LightningMesh
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LightningMesh+StrikeProperties")]
public partial class StrikeProperties : global::FrooxEngine.SyncObject

{
    public global::System.Int32 Segments;
public global::System.Single StartWidth;
public global::System.Single EndWidth;
public global::System.Single MinOffset;
public global::System.Single MaxOffset;
public global::System.Int32 ChildCount;
public global::System.Single MinChildTargetDistanceRatio;
public global::System.Single MaxChildTargetDistanceRatio;
public global::System.Single MinChildTargetOffset;
public global::System.Single MaxChildTargetOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Segments", Segments.ToResoniteLinkField());
members.Add("StartWidth", StartWidth.ToResoniteLinkField());
members.Add("EndWidth", EndWidth.ToResoniteLinkField());
members.Add("MinOffset", MinOffset.ToResoniteLinkField());
members.Add("MaxOffset", MaxOffset.ToResoniteLinkField());
members.Add("ChildCount", ChildCount.ToResoniteLinkField());
members.Add("MinChildTargetDistanceRatio", MinChildTargetDistanceRatio.ToResoniteLinkField());
members.Add("MaxChildTargetDistanceRatio", MaxChildTargetDistanceRatio.ToResoniteLinkField());
members.Add("MinChildTargetOffset", MinChildTargetOffset.ToResoniteLinkField());
members.Add("MaxChildTargetOffset", MaxChildTargetOffset.ToResoniteLinkField());
}

}
            }
}
