
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CameraControlTool
// Generated on: středa 25. února 2026 16:14:19
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
    public global::FrooxEngine.CameraControlTool.CameraMode Mode;
public global::FrooxEngine.FresnelMaterial _material;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("_material", _material.ToResoniteReference(context));
}

}
}
