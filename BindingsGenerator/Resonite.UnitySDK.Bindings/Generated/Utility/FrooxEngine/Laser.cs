
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Laser
// Generated on: pátek 6. března 2026 14:19:12
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.PBS_RimMetallic _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _material_Element = new();
public global::FrooxEngine.RayDriver _rayDriver { get => _rayDriver_Element.Data; set => _rayDriver_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.RayDriver>, global::FrooxEngine.RayDriver> _rayDriver_Element = new();
public global::FrooxEngine.MeshRenderer _meshRenderer { get => _meshRenderer_Element.Data; set => _meshRenderer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> _meshRenderer_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_material", _material_Element.ToLinkReference(context));
members.Add("_rayDriver", _rayDriver_Element.ToLinkReference(context));
members.Add("_meshRenderer", _meshRenderer_Element.ToLinkReference(context));
}

}
}
