
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.PivotFromVelocityMagnitude
// Generated on: čtvrtek 26. února 2026 15:09:05
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.PivotFromVelocityMagnitude")]
public partial class PivotFromVelocityMagnitude : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 PivotBaseOffset { get => PivotBaseOffset_Element.Data; set => PivotBaseOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> PivotBaseOffset_Element = new();
public UnityEngine.Vector3 PivotClampMin { get => PivotClampMin_Element.Data; set => PivotClampMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> PivotClampMin_Element = new();
public UnityEngine.Vector3 PivotClampMax { get => PivotClampMax_Element.Data; set => PivotClampMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> PivotClampMax_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PivotBaseOffset", PivotBaseOffset_Element.ToLinkField(context));
members.Add("PivotClampMin", PivotClampMin_Element.ToLinkField(context));
members.Add("PivotClampMax", PivotClampMax_Element.ToLinkField(context));
}

}
}
