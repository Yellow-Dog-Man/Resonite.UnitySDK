
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LabelPointerMesh
// Generated on: středa 25. února 2026 16:13:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LabelPointerMesh")]
public partial class LabelPointerMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 LabelPoint;
public UnityEngine.Vector3 TargetPoint;
public UnityEngine.Quaternion LabelRotation;
public global::System.Single LabelWidth;
public global::System.Single Width;
public global::System.Single ExpandLerp;
public global::System.Boolean DualSided;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LabelPoint", LabelPoint.ToResoniteLinkField());
members.Add("TargetPoint", TargetPoint.ToResoniteLinkField());
members.Add("LabelRotation", LabelRotation.ToResoniteLinkField());
members.Add("LabelWidth", LabelWidth.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("ExpandLerp", ExpandLerp.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
}

}
}
