
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.OrientByVelocity
// Generated on: čtvrtek 26. února 2026 12:28:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.OrientByVelocity")]
public partial class OrientByVelocity : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.Vector3 Up { get => Up_Element.Data; set => Up_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Up_Element = new();
public global::System.Single MinimumVelocity { get => MinimumVelocity_Element.Data; set => MinimumVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinimumVelocity_Element = new();
public global::System.Single VelocityTransitionRange { get => VelocityTransitionRange_Element.Data; set => VelocityTransitionRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VelocityTransitionRange_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Up", Up_Element.ToLinkField(context));
members.Add("MinimumVelocity", MinimumVelocity_Element.ToLinkField(context));
members.Add("VelocityTransitionRange", VelocityTransitionRange_Element.ToLinkField(context));
}

}
}
