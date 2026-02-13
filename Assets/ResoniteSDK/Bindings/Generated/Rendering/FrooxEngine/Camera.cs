
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Camera
// Generated on: pátek 13. února 2026 5:51:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Camera")]
public partial class Camera : global::FrooxEngine.ChangeHandlingRenderableComponent, global::FrooxEngine.IUVToRayConverter

{
    public global::System.Boolean DoubleBuffered;
public global::System.Boolean ForwardOnly;
public global::Renderite.Shared.CameraProjection Projection;
public global::System.Single OrthographicSize;
public global::System.Single FieldOfView;
public global::System.Single NearClipping;
public global::System.Single FarClipping;
public global::System.Boolean UseTransformScale;
public global::Renderite.Shared.CameraClearMode Clear;
public UnityEngine.ColorX ClearColor;
public UnityEngine.Rect Viewport;
public global::System.Single Depth;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.RenderTexture> RenderTexture;
public global::System.Boolean Postprocessing;
public global::System.Boolean ScreenSpaceReflections;
public global::System.Boolean MotionBlur;
public global::System.Boolean RenderShadows;
public System.Collections.Generic.List<global::FrooxEngine.Slot> SelectiveRender;
public System.Collections.Generic.List<global::FrooxEngine.Slot> ExcludeRender;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DoubleBuffered", DoubleBuffered.ToResoniteLinkField());
members.Add("ForwardOnly", ForwardOnly.ToResoniteLinkField());
members.Add("Projection", Projection.ToResoniteLinkField());
members.Add("OrthographicSize", OrthographicSize.ToResoniteLinkField());
members.Add("FieldOfView", FieldOfView.ToResoniteLinkField());
members.Add("NearClipping", NearClipping.ToResoniteLinkField());
members.Add("FarClipping", FarClipping.ToResoniteLinkField());
members.Add("UseTransformScale", UseTransformScale.ToResoniteLinkField());
members.Add("Clear", Clear.ToResoniteLinkField());
members.Add("ClearColor", ClearColor.ToResoniteLinkField());
members.Add("Viewport", Viewport.ToResoniteLinkField());
members.Add("Depth", Depth.ToResoniteLinkField());
members.Add("RenderTexture", new ResoniteLink.Reference() { });
members.Add("Postprocessing", Postprocessing.ToResoniteLinkField());
members.Add("ScreenSpaceReflections", ScreenSpaceReflections.ToResoniteLinkField());
members.Add("MotionBlur", MotionBlur.ToResoniteLinkField());
members.Add("RenderShadows", RenderShadows.ToResoniteLinkField());
members.Add("SelectiveRender", new ResoniteLink.SyncList()
{
    Elements = SelectiveRender.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("ExcludeRender", new ResoniteLink.SyncList()
{
    Elements = ExcludeRender.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
}

}
}
