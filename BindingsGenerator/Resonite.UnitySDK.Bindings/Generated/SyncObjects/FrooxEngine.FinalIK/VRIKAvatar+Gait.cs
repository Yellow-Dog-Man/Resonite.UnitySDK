
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.VRIKAvatar+Gait
// Generated on: čtvrtek 26. února 2026 10:04:45
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::System.Single MinimumVelocity { get => MinimumVelocity_Element.Data; set => MinimumVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinimumVelocity_Element = new();
public UnityEngine.Vector2 FeetRange { get => FeetRange_Element.Data; set => FeetRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FeetRange_Element = new();
public global::System.Single CycleHeightBias { get => CycleHeightBias_Element.Data; set => CycleHeightBias_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CycleHeightBias_Element = new();
public global::System.Single CycleFeetSeparation { get => CycleFeetSeparation_Element.Data; set => CycleFeetSeparation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CycleFeetSeparation_Element = new();
public global::System.Single CycleGroundRatio { get => CycleGroundRatio_Element.Data; set => CycleGroundRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CycleGroundRatio_Element = new();
public global::System.Single FootRaiseBeginHeight { get => FootRaiseBeginHeight_Element.Data; set => FootRaiseBeginHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootRaiseBeginHeight_Element = new();
public global::System.Single FootRaiseEndHeight { get => FootRaiseEndHeight_Element.Data; set => FootRaiseEndHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootRaiseEndHeight_Element = new();
public global::System.Single FootRestAngle { get => FootRestAngle_Element.Data; set => FootRestAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootRestAngle_Element = new();
public global::System.Single FootRaiseAngle { get => FootRaiseAngle_Element.Data; set => FootRaiseAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FootRaiseAngle_Element = new();
public global::System.Single FeetAlignmentOffset { get => FeetAlignmentOffset_Element.Data; set => FeetAlignmentOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FeetAlignmentOffset_Element = new();
public global::System.Single SpeedRatio { get => SpeedRatio_Element.Data; set => SpeedRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpeedRatio_Element = new();
public global::System.Single FeetSlipRatio { get => FeetSlipRatio_Element.Data; set => FeetSlipRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FeetSlipRatio_Element = new();
public global::System.Single ForwardOffset { get => ForwardOffset_Element.Data; set => ForwardOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ForwardOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinimumVelocity", MinimumVelocity_Element.Data.ToResoniteLinkField());
members.Add("FeetRange", FeetRange_Element.Data.ToResoniteLinkField());
members.Add("CycleHeightBias", CycleHeightBias_Element.Data.ToResoniteLinkField());
members.Add("CycleFeetSeparation", CycleFeetSeparation_Element.Data.ToResoniteLinkField());
members.Add("CycleGroundRatio", CycleGroundRatio_Element.Data.ToResoniteLinkField());
members.Add("FootRaiseBeginHeight", FootRaiseBeginHeight_Element.Data.ToResoniteLinkField());
members.Add("FootRaiseEndHeight", FootRaiseEndHeight_Element.Data.ToResoniteLinkField());
members.Add("FootRestAngle", FootRestAngle_Element.Data.ToResoniteLinkField());
members.Add("FootRaiseAngle", FootRaiseAngle_Element.Data.ToResoniteLinkField());
members.Add("FeetAlignmentOffset", FeetAlignmentOffset_Element.Data.ToResoniteLinkField());
members.Add("SpeedRatio", SpeedRatio_Element.Data.ToResoniteLinkField());
members.Add("FeetSlipRatio", FeetSlipRatio_Element.Data.ToResoniteLinkField());
members.Add("ForwardOffset", ForwardOffset_Element.Data.ToResoniteLinkField());
}

}
            }
}
