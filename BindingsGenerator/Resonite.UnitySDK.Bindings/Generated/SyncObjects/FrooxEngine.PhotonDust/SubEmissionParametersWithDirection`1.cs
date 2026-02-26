
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SubEmissionParametersWithDirection<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SubEmissionParametersWithDirection<>")]
public partial class SubEmissionParametersWithDirection<P> : global::FrooxEngine.SyncObject
	where P : global::PhotonDust.SubEmissionParametersWithDirection

{
    public global::FrooxEngine.PhotonDust.ParticleSystem TargetSystem { get => TargetSystem_Element.Data; set => TargetSystem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.ParticleSystem>, global::FrooxEngine.PhotonDust.ParticleSystem> TargetSystem_Element = new();
public global::System.Boolean InheritOrientation { get => InheritOrientation_Element.Data; set => InheritOrientation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InheritOrientation_Element = new();
public global::System.Boolean InheritScale { get => InheritScale_Element.Data; set => InheritScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InheritScale_Element = new();
public global::System.Boolean InheritColor { get => InheritColor_Element.Data; set => InheritColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InheritColor_Element = new();
public global::PhotonDust.SubEmissionParametersWithDirection.DirectionInheritanceMode DirectionInheritance { get => DirectionInheritance_Element.Data; set => DirectionInheritance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.SubEmissionParametersWithDirection.DirectionInheritanceMode>, global::PhotonDust.SubEmissionParametersWithDirection.DirectionInheritanceMode> DirectionInheritance_Element = new();
public UnityEngine.Vector3 Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction_Element = new();
public global::System.Single RandomDirectionWeight { get => RandomDirectionWeight_Element.Data; set => RandomDirectionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RandomDirectionWeight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSystem", TargetSystem_Element.ToLinkReference(context));
members.Add("InheritOrientation", InheritOrientation_Element.ToLinkField(context));
members.Add("InheritScale", InheritScale_Element.ToLinkField(context));
members.Add("InheritColor", InheritColor_Element.ToLinkField(context));
members.Add("DirectionInheritance", DirectionInheritance_Element.ToLinkField(context));
members.Add("Direction", Direction_Element.ToLinkField(context));
members.Add("RandomDirectionWeight", RandomDirectionWeight_Element.ToLinkField(context));
}

}
}
