
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorDepthBase
// Generated on: úterý 24. února 2026 18:17:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorDepthBase")]
public abstract partial class ColorDepthBase : global::FrooxEngine.ProceduralMesh

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> ColorTexture;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> DepthTexture;
public global::FrooxEngine.PointProjection Projection;
public global::System.Single HorizontalAngle;
public global::System.Single VerticalAngle;
public global::System.Single DepthOffset;
public global::System.Single DepthScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ColorTexture", ColorTexture.ToResoniteReference(context));
members.Add("DepthTexture", DepthTexture.ToResoniteReference(context));
members.Add("Projection", Projection.ToResoniteLinkField());
members.Add("HorizontalAngle", HorizontalAngle.ToResoniteLinkField());
members.Add("VerticalAngle", VerticalAngle.ToResoniteLinkField());
members.Add("DepthOffset", DepthOffset.ToResoniteLinkField());
members.Add("DepthScale", DepthScale.ToResoniteLinkField());
}

}
}
