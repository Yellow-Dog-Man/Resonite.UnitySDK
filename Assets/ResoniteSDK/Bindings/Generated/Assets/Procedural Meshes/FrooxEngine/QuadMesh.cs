
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuadMesh
// Generated on: pátek 13. února 2026 23:21:35
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
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
