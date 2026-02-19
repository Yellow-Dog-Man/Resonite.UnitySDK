
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuadMesh
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.QuadMesh")]
public partial class QuadMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Quaternion Rotation;
public UnityEngine.Vector2 Size;
public UnityEngine.Vector2 UVOffset;
public UnityEngine.Vector2 UVScale;
public global::System.Boolean ScaleUVWithSize;
public global::System.Boolean DualSided;
public global::System.Boolean UseVertexColors;
public UnityEngine.ColorX UpperLeftColor;
public UnityEngine.ColorX LowerLeftColor;
public UnityEngine.ColorX LowerRightColor;
public UnityEngine.ColorX UpperRightColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rotation", Rotation.ToResoniteLinkField());
members.Add("Size", Size.ToResoniteLinkField());
members.Add("UVOffset", UVOffset.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("ScaleUVWithSize", ScaleUVWithSize.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
members.Add("UseVertexColors", UseVertexColors.ToResoniteLinkField());
members.Add("UpperLeftColor", UpperLeftColor.ToResoniteLinkField());
members.Add("LowerLeftColor", LowerLeftColor.ToResoniteLinkField());
members.Add("LowerRightColor", LowerRightColor.ToResoniteLinkField());
members.Add("UpperRightColor", UpperRightColor.ToResoniteLinkField());
}

}
}
