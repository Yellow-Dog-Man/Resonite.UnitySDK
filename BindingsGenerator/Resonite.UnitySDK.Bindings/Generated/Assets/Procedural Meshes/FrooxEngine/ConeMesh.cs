
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ConeMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ConeMesh")]
public partial class ConeMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Height;
public global::System.Single RadiusBase;
public global::System.Single RadiusTop;
public global::System.Int32 Sides;
public global::System.Boolean Caps;
public global::System.Boolean FlatShading;
public UnityEngine.Vector2 UVScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Height", Height.ToResoniteLinkField());
members.Add("RadiusBase", RadiusBase.ToResoniteLinkField());
members.Add("RadiusTop", RadiusTop.ToResoniteLinkField());
members.Add("Sides", Sides.ToResoniteLinkField());
members.Add("Caps", Caps.ToResoniteLinkField());
members.Add("FlatShading", FlatShading.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
}

}
}
