
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorDepthBase
// Generated on: čtvrtek 26. února 2026 10:03:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorDepthBase")]
public abstract partial class ColorDepthBase : global::FrooxEngine.ProceduralMesh

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> ColorTexture { get => ColorTexture_Element.Data; set => ColorTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> ColorTexture_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> DepthTexture { get => DepthTexture_Element.Data; set => DepthTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Texture2D>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D>> DepthTexture_Element = new();
public global::FrooxEngine.PointProjection Projection { get => Projection_Element.Data; set => Projection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PointProjection>, global::FrooxEngine.PointProjection> Projection_Element = new();
public global::System.Single HorizontalAngle { get => HorizontalAngle_Element.Data; set => HorizontalAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HorizontalAngle_Element = new();
public global::System.Single VerticalAngle { get => VerticalAngle_Element.Data; set => VerticalAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VerticalAngle_Element = new();
public global::System.Single DepthOffset { get => DepthOffset_Element.Data; set => DepthOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DepthOffset_Element = new();
public global::System.Single DepthScale { get => DepthScale_Element.Data; set => DepthScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DepthScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ColorTexture", ColorTexture_Element.Data.ToResoniteReference(context));
members.Add("DepthTexture", DepthTexture_Element.Data.ToResoniteReference(context));
members.Add("Projection", Projection_Element.Data.ToResoniteLinkField());
members.Add("HorizontalAngle", HorizontalAngle_Element.Data.ToResoniteLinkField());
members.Add("VerticalAngle", VerticalAngle_Element.Data.ToResoniteLinkField());
members.Add("DepthOffset", DepthOffset_Element.Data.ToResoniteLinkField());
members.Add("DepthScale", DepthScale_Element.Data.ToResoniteLinkField());
}

}
}
