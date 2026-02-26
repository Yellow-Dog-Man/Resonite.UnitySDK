
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Camera
// Generated on: čtvrtek 26. února 2026 10:03:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Camera")]
public partial class Camera : global::FrooxEngine.ChangeHandlingRenderableComponent, global::FrooxEngine.IUVToRayConverter

{
    public global::System.Boolean DoubleBuffered { get => DoubleBuffered_Element.Data; set => DoubleBuffered_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DoubleBuffered_Element = new();
public global::System.Boolean ForwardOnly { get => ForwardOnly_Element.Data; set => ForwardOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForwardOnly_Element = new();
public global::Renderite.Shared.CameraProjection Projection { get => Projection_Element.Data; set => Projection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.CameraProjection>, global::Renderite.Shared.CameraProjection> Projection_Element = new();
public global::System.Single OrthographicSize { get => OrthographicSize_Element.Data; set => OrthographicSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OrthographicSize_Element = new();
public global::System.Single FieldOfView { get => FieldOfView_Element.Data; set => FieldOfView_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FieldOfView_Element = new();
public global::System.Single NearClipping { get => NearClipping_Element.Data; set => NearClipping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NearClipping_Element = new();
public global::System.Single FarClipping { get => FarClipping_Element.Data; set => FarClipping_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FarClipping_Element = new();
public global::System.Boolean UseTransformScale { get => UseTransformScale_Element.Data; set => UseTransformScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseTransformScale_Element = new();
public global::Renderite.Shared.CameraClearMode Clear { get => Clear_Element.Data; set => Clear_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.CameraClearMode>, global::Renderite.Shared.CameraClearMode> Clear_Element = new();
public UnityEngine.ColorX ClearColor { get => ClearColor_Element.Data; set => ClearColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> ClearColor_Element = new();
public UnityEngine.Rect Viewport { get => Viewport_Element.Data; set => Viewport_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> Viewport_Element = new();
public global::System.Single Depth { get => Depth_Element.Data; set => Depth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Depth_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.RenderTexture> RenderTexture { get => RenderTexture_Element.Data; set => RenderTexture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.RenderTexture>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.RenderTexture>> RenderTexture_Element = new();
public global::System.Boolean Postprocessing { get => Postprocessing_Element.Data; set => Postprocessing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Postprocessing_Element = new();
public global::System.Boolean ScreenSpaceReflections { get => ScreenSpaceReflections_Element.Data; set => ScreenSpaceReflections_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScreenSpaceReflections_Element = new();
public global::System.Boolean MotionBlur { get => MotionBlur_Element.Data; set => MotionBlur_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MotionBlur_Element = new();
public global::System.Boolean RenderShadows { get => RenderShadows_Element.Data; set => RenderShadows_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RenderShadows_Element = new();
public global::SyncFieldList<global::FrooxEngine.AutoSyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Field<global::FrooxEngine.AutoSyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> SelectiveRender = new();
public global::SyncFieldList<global::FrooxEngine.AutoSyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Field<global::FrooxEngine.AutoSyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> ExcludeRender = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DoubleBuffered", DoubleBuffered_Element.Data.ToResoniteLinkField());
members.Add("ForwardOnly", ForwardOnly_Element.Data.ToResoniteLinkField());
members.Add("Projection", Projection_Element.Data.ToResoniteLinkField());
members.Add("OrthographicSize", OrthographicSize_Element.Data.ToResoniteLinkField());
members.Add("FieldOfView", FieldOfView_Element.Data.ToResoniteLinkField());
members.Add("NearClipping", NearClipping_Element.Data.ToResoniteLinkField());
members.Add("FarClipping", FarClipping_Element.Data.ToResoniteLinkField());
members.Add("UseTransformScale", UseTransformScale_Element.Data.ToResoniteLinkField());
members.Add("Clear", Clear_Element.Data.ToResoniteLinkField());
members.Add("ClearColor", ClearColor_Element.Data.ToResoniteLinkField());
members.Add("Viewport", Viewport_Element.Data.ToResoniteLinkField());
members.Add("Depth", Depth_Element.Data.ToResoniteLinkField());
members.Add("RenderTexture", RenderTexture_Element.Data.ToResoniteReference(context));
members.Add("Postprocessing", Postprocessing_Element.Data.ToResoniteLinkField());
members.Add("ScreenSpaceReflections", ScreenSpaceReflections_Element.Data.ToResoniteLinkField());
members.Add("MotionBlur", MotionBlur_Element.Data.ToResoniteLinkField());
members.Add("RenderShadows", RenderShadows_Element.Data.ToResoniteLinkField());
members.Add("SelectiveRender", new ResoniteLink.SyncList()
{
    Elements = SelectiveRender.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("ExcludeRender", new ResoniteLink.SyncList()
{
    Elements = ExcludeRender.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
}

}
}
