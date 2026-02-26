
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.PositionSimulatorSubEmissionParameters
// Generated on: čtvrtek 26. února 2026 12:28:05
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.PositionSimulatorSubEmissionParameters")]
public partial class PositionSimulatorSubEmissionParameters : global::FrooxEngine.PhotonDust.SubEmissionParameters<global::PhotonDust.PositionSimulatorSubEmissionParameters>

{
    public global::System.Boolean InheritLifetime { get => InheritLifetime_Element.Data; set => InheritLifetime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InheritLifetime_Element = new();
public global::PhotonDust.PositionSimulatorSubEmissionParameters.VelocityInheritanceMode VelocityInheritanceMode { get => VelocityInheritanceMode_Element.Data; set => VelocityInheritanceMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.PositionSimulatorSubEmissionParameters.VelocityInheritanceMode>, global::PhotonDust.PositionSimulatorSubEmissionParameters.VelocityInheritanceMode> VelocityInheritanceMode_Element = new();
public global::System.Single RandomDirectionWeight { get => RandomDirectionWeight_Element.Data; set => RandomDirectionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RandomDirectionWeight_Element = new();
public global::System.Int32 CollisionEmissionMin { get => CollisionEmissionMin_Element.Data; set => CollisionEmissionMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> CollisionEmissionMin_Element = new();
public global::System.Int32 CollisionEmissionMax { get => CollisionEmissionMax_Element.Data; set => CollisionEmissionMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> CollisionEmissionMax_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InheritLifetime", InheritLifetime_Element.ToLinkField(context));
members.Add("VelocityInheritanceMode", VelocityInheritanceMode_Element.ToLinkField(context));
members.Add("RandomDirectionWeight", RandomDirectionWeight_Element.ToLinkField(context));
members.Add("CollisionEmissionMin", CollisionEmissionMin_Element.ToLinkField(context));
members.Add("CollisionEmissionMax", CollisionEmissionMax_Element.ToLinkField(context));
}

}
}
