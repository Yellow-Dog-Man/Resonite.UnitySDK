
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorDepthBase
// Generated on: pátek 13. února 2026 5:51:08
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ColorTexture", new ResoniteLink.Reference() { });
members.Add("DepthTexture", new ResoniteLink.Reference() { });
members.Add("Projection", Projection.ToResoniteLinkField());
members.Add("HorizontalAngle", HorizontalAngle.ToResoniteLinkField());
members.Add("VerticalAngle", VerticalAngle.ToResoniteLinkField());
members.Add("DepthOffset", DepthOffset.ToResoniteLinkField());
members.Add("DepthScale", DepthScale.ToResoniteLinkField());
}

}
}
