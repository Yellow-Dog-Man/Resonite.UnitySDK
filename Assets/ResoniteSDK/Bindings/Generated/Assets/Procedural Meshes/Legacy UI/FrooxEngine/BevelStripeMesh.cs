
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BevelStripeMesh
// Generated on: čtvrtek 19. února 2026 7:58:53
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BevelStripeMesh")]
public partial class BevelStripeMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Width;
public global::System.Single Height;
public global::System.Single Thickness;
public global::System.Single SlantLeft;
public global::System.Single SlantRight;
public global::System.Boolean Relief;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("SlantLeft", SlantLeft.ToResoniteLinkField());
members.Add("SlantRight", SlantRight.ToResoniteLinkField());
members.Add("Relief", Relief.ToResoniteLinkField());
}

}
}
