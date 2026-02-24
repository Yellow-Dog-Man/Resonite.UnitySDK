
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleObjectManager
// Generated on: úterý 24. února 2026 18:20:16
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleObjectManager")]
public partial class ScaleObjectManager : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::System.Single ScalePower;
public global::System.Single LowerBound;
public global::System.Single UpperBound;
public global::System.Single FarSizeTransitionRange;
public global::System.Single FarSizeTransitionExp;
public global::System.Single NearSizeTransitionRange;
public global::System.Single NearSizeTransitionExp;
public global::System.Single FarOffsetTransitionRange;
public global::System.Single FarOffsetTransitionExp;
public UnityEngine.Vector3 FarTransitionOffset;
public global::System.Single NearOffsetTransitionRange;
public global::System.Single NearOffsetTransitionExp;
public UnityEngine.Vector3 NearTransitionOffset;
public global::System.Single CenterOffsetRadius;
public global::System.Single OptimalDistance;
public UnityEngine.Vector3 CoordinatePowerBase;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScalePower", ScalePower.ToResoniteLinkField());
members.Add("LowerBound", LowerBound.ToResoniteLinkField());
members.Add("UpperBound", UpperBound.ToResoniteLinkField());
members.Add("FarSizeTransitionRange", FarSizeTransitionRange.ToResoniteLinkField());
members.Add("FarSizeTransitionExp", FarSizeTransitionExp.ToResoniteLinkField());
members.Add("NearSizeTransitionRange", NearSizeTransitionRange.ToResoniteLinkField());
members.Add("NearSizeTransitionExp", NearSizeTransitionExp.ToResoniteLinkField());
members.Add("FarOffsetTransitionRange", FarOffsetTransitionRange.ToResoniteLinkField());
members.Add("FarOffsetTransitionExp", FarOffsetTransitionExp.ToResoniteLinkField());
members.Add("FarTransitionOffset", FarTransitionOffset.ToResoniteLinkField());
members.Add("NearOffsetTransitionRange", NearOffsetTransitionRange.ToResoniteLinkField());
members.Add("NearOffsetTransitionExp", NearOffsetTransitionExp.ToResoniteLinkField());
members.Add("NearTransitionOffset", NearTransitionOffset.ToResoniteLinkField());
members.Add("CenterOffsetRadius", CenterOffsetRadius.ToResoniteLinkField());
members.Add("OptimalDistance", OptimalDistance.ToResoniteLinkField());
members.Add("CoordinatePowerBase", CoordinatePowerBase.ToResoniteLinkField());
}

}
}
