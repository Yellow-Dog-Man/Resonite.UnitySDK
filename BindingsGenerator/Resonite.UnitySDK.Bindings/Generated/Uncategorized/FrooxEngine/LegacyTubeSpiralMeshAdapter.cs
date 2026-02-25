
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyTubeSpiralMeshAdapter
// Generated on: středa 25. února 2026 16:14:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyTubeSpiralMeshAdapter")]
public partial class LegacyTubeSpiralMeshAdapter : global::FrooxEngine.Component

{
    public global::System.Single UpwardTrend;
public global::System.Single Length;
public global::FrooxEngine.IField<UnityEngine.Vector3> EndPoint;
public global::FrooxEngine.IField<global::System.Single> CoilCount;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpwardTrend", UpwardTrend.ToResoniteLinkField());
members.Add("Length", Length.ToResoniteLinkField());
members.Add("EndPoint", EndPoint.ToResoniteReference(context));
members.Add("CoilCount", CoilCount.ToResoniteReference(context));
}

}
}
