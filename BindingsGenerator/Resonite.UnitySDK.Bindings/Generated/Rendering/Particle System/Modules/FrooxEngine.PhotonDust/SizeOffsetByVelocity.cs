
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SizeOffsetByVelocity
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SizeOffsetByVelocity")]
public partial class SizeOffsetByVelocity : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 VelocityMultiplier { get => VelocityMultiplier_Element.Data; set => VelocityMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> VelocityMultiplier_Element = new();
public UnityEngine.Vector3 OffsetClampMin { get => OffsetClampMin_Element.Data; set => OffsetClampMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> OffsetClampMin_Element = new();
public UnityEngine.Vector3 OffsetClampMax { get => OffsetClampMax_Element.Data; set => OffsetClampMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> OffsetClampMax_Element = new();
public UnityEngine.Vector3 ResultClampMin { get => ResultClampMin_Element.Data; set => ResultClampMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ResultClampMin_Element = new();
public UnityEngine.Vector3 ResultClampMax { get => ResultClampMax_Element.Data; set => ResultClampMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ResultClampMax_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VelocityMultiplier", VelocityMultiplier_Element.ToLinkField(context));
members.Add("OffsetClampMin", OffsetClampMin_Element.ToLinkField(context));
members.Add("OffsetClampMax", OffsetClampMax_Element.ToLinkField(context));
members.Add("ResultClampMin", ResultClampMin_Element.ToLinkField(context));
members.Add("ResultClampMax", ResultClampMax_Element.ToLinkField(context));
}

}
}
