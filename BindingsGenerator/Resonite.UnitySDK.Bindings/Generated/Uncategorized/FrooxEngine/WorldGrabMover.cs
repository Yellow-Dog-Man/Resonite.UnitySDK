
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldGrabMover
// Generated on: středa 25. února 2026 16:14:44
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldGrabMover")]
public partial class WorldGrabMover : global::FrooxEngine.Component

{
    public global::System.Single ShowLerp;
public global::FrooxEngine.User _activatingUser;
public global::FrooxEngine.CrossMesh _crossMesh;
public global::FrooxEngine.IField<global::System.Boolean> _visualVisible;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRotation;
public global::FrooxEngine.PBS_RimMetallic _material;
public UnityEngine.Vector3 _referencePosition;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ShowLerp", ShowLerp.ToResoniteLinkField());
members.Add("_activatingUser", _activatingUser.ToResoniteReference(context));
members.Add("_crossMesh", _crossMesh.ToResoniteReference(context));
members.Add("_visualVisible", _visualVisible.ToResoniteReference(context));
members.Add("_visualRotation", _visualRotation.ToResoniteReference(context));
members.Add("_material", _material.ToResoniteReference(context));
members.Add("_referencePosition", _referencePosition.ToResoniteLinkField());
}

}
}
