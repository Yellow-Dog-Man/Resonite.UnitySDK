
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BevelPlaneMesh
// Generated on: úterý 24. února 2026 18:17:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BevelPlaneMesh")]
public partial class BevelPlaneMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Width;
public global::System.Single Height;
public global::System.Single Thickness;
public global::System.Single TopLeftCut;
public global::System.Single BottomRightCut;
public global::System.Boolean Relief;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("TopLeftCut", TopLeftCut.ToResoniteLinkField());
members.Add("BottomRightCut", BottomRightCut.ToResoniteLinkField());
members.Add("Relief", Relief.ToResoniteLinkField());
}

}
}
