
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BevelRingMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BevelRingMesh")]
public partial class BevelRingMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Arc;
public global::System.Single ArcOffset;
public global::System.Single Radius;
public global::System.Single Width;
public global::System.Single Thickness;
public global::System.Single Tilt;
public global::System.Int32 Segments;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Arc", Arc.ToResoniteLinkField());
members.Add("ArcOffset", ArcOffset.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("Tilt", Tilt.ToResoniteLinkField());
members.Add("Segments", Segments.ToResoniteLinkField());
}

}
}
