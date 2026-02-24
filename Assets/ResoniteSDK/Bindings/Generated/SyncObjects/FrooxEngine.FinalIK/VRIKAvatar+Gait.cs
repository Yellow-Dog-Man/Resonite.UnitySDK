
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.VRIKAvatar+Gait
// Generated on: úterý 24. února 2026 18:20:22
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FinalIK
{
    public partial class VRIKAvatar
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.VRIKAvatar+Gait")]
public partial class Gait : global::FrooxEngine.SyncObject

{
    public global::System.Single MinimumVelocity;
public UnityEngine.Vector2 FeetRange;
public global::System.Single CycleHeightBias;
public global::System.Single CycleFeetSeparation;
public global::System.Single CycleGroundRatio;
public global::System.Single FootRaiseBeginHeight;
public global::System.Single FootRaiseEndHeight;
public global::System.Single FootRestAngle;
public global::System.Single FootRaiseAngle;
public global::System.Single FeetAlignmentOffset;
public global::System.Single SpeedRatio;
public global::System.Single FeetSlipRatio;
public global::System.Single ForwardOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinimumVelocity", MinimumVelocity.ToResoniteLinkField());
members.Add("FeetRange", FeetRange.ToResoniteLinkField());
members.Add("CycleHeightBias", CycleHeightBias.ToResoniteLinkField());
members.Add("CycleFeetSeparation", CycleFeetSeparation.ToResoniteLinkField());
members.Add("CycleGroundRatio", CycleGroundRatio.ToResoniteLinkField());
members.Add("FootRaiseBeginHeight", FootRaiseBeginHeight.ToResoniteLinkField());
members.Add("FootRaiseEndHeight", FootRaiseEndHeight.ToResoniteLinkField());
members.Add("FootRestAngle", FootRestAngle.ToResoniteLinkField());
members.Add("FootRaiseAngle", FootRaiseAngle.ToResoniteLinkField());
members.Add("FeetAlignmentOffset", FeetAlignmentOffset.ToResoniteLinkField());
members.Add("SpeedRatio", SpeedRatio.ToResoniteLinkField());
members.Add("FeetSlipRatio", FeetSlipRatio.ToResoniteLinkField());
members.Add("ForwardOffset", ForwardOffset.ToResoniteLinkField());
}

}
            }
}
