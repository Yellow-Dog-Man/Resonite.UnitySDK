
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Laser
// Generated on: úterý 24. února 2026 18:20:33
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Laser")]
public partial class Laser : global::FrooxEngine.Component

{
    public global::FrooxEngine.PBS_RimMetallic _material;
public global::FrooxEngine.RayDriver _rayDriver;
public global::FrooxEngine.MeshRenderer _meshRenderer;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_material", _material.ToResoniteReference(context));
members.Add("_rayDriver", _rayDriver.ToResoniteReference(context));
members.Add("_meshRenderer", _meshRenderer.ToResoniteReference(context));
}

}
}
