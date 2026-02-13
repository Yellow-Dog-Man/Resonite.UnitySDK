
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BevelPlaneMesh
// Generated on: pátek 13. února 2026 5:51:09
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("TopLeftCut", TopLeftCut.ToResoniteLinkField());
members.Add("BottomRightCut", BottomRightCut.ToResoniteLinkField());
members.Add("Relief", Relief.ToResoniteLinkField());
}

}
}
