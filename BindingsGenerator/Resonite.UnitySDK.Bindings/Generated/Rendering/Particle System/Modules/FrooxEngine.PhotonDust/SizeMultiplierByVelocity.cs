
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SizeMultiplierByVelocity
// Generated on: čtvrtek 26. února 2026 10:04:38
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SizeMultiplierByVelocity")]
public partial class SizeMultiplierByVelocity : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 VelocityMultiplier { get => VelocityMultiplier_Element.Data; set => VelocityMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> VelocityMultiplier_Element = new();
public UnityEngine.Vector3Bool VelocityMask { get => VelocityMask_Element.Data; set => VelocityMask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3Bool>, UnityEngine.Vector3Bool> VelocityMask_Element = new();
public UnityEngine.Vector3 MultiplierClampMin { get => MultiplierClampMin_Element.Data; set => MultiplierClampMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MultiplierClampMin_Element = new();
public UnityEngine.Vector3 MultiplierClampMax { get => MultiplierClampMax_Element.Data; set => MultiplierClampMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MultiplierClampMax_Element = new();
public UnityEngine.Vector3 ResultClampMin { get => ResultClampMin_Element.Data; set => ResultClampMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ResultClampMin_Element = new();
public UnityEngine.Vector3 ResultClampMax { get => ResultClampMax_Element.Data; set => ResultClampMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ResultClampMax_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VelocityMultiplier", VelocityMultiplier_Element.Data.ToResoniteLinkField());
members.Add("VelocityMask", VelocityMask_Element.Data.ToResoniteLinkField());
members.Add("MultiplierClampMin", MultiplierClampMin_Element.Data.ToResoniteLinkField());
members.Add("MultiplierClampMax", MultiplierClampMax_Element.Data.ToResoniteLinkField());
members.Add("ResultClampMin", ResultClampMin_Element.Data.ToResoniteLinkField());
members.Add("ResultClampMax", ResultClampMax_Element.Data.ToResoniteLinkField());
}

}
}
