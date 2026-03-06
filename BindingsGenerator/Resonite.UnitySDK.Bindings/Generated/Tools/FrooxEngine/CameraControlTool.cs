
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CameraControlTool
// Generated on: pátek 6. března 2026 14:19:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CameraControlTool")]
public partial class CameraControlTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.CameraControlTool.CameraMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CameraControlTool.CameraMode>, global::FrooxEngine.CameraControlTool.CameraMode> Mode_Element = new();
public global::FrooxEngine.FresnelMaterial _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.FresnelMaterial>, global::FrooxEngine.FresnelMaterial> _material_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("_material", _material_Element.ToLinkReference(context));
}

}
}
