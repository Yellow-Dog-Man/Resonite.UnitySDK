
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CameraControlTool
// Generated on: čtvrtek 26. února 2026 10:04:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CameraControlTool")]
public partial class CameraControlTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.CameraControlTool.CameraMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CameraControlTool.CameraMode>, global::FrooxEngine.CameraControlTool.CameraMode> Mode_Element = new();
public global::FrooxEngine.FresnelMaterial _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.FresnelMaterial>, global::FrooxEngine.FresnelMaterial> _material_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode_Element.Data.ToResoniteLinkField());
members.Add("_material", _material_Element.Data.ToResoniteReference(context));
}

}
}
