
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.RadialForceBase<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.RadialForceBase<>")]
public abstract partial class RadialForceBase<T> : global::FrooxEngine.PhotonDust.ParticleSystemModule<T>
	

{
    public global::System.Single Force { get => Force_Element.Data; set => Force_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Force_Element = new();
public global::PhotonDust.RadialForceMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.RadialForceMode>, global::PhotonDust.RadialForceMode> Mode_Element = new();
public global::System.Single MinDistance { get => MinDistance_Element.Data; set => MinDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinDistance_Element = new();
public global::System.Single MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxDistance_Element = new();
public global::System.Single MinForce { get => MinForce_Element.Data; set => MinForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinForce_Element = new();
public global::System.Single MaxForce { get => MaxForce_Element.Data; set => MaxForce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxForce_Element = new();
public global::FrooxEngine.RootSpace OverrideForceSpace = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Force", Force_Element.Data.ToResoniteLinkField());
members.Add("Mode", Mode_Element.Data.ToResoniteLinkField());
members.Add("MinDistance", MinDistance_Element.Data.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance_Element.Data.ToResoniteLinkField());
members.Add("MinForce", MinForce_Element.Data.ToResoniteLinkField());
members.Add("MaxForce", MaxForce_Element.Data.ToResoniteLinkField());
members.Add("OverrideForceSpace", new ResoniteLink.SyncObject() { Members = OverrideForceSpace.CollectMembers(context) });
}

}
}
