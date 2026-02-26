
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDash
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantDash")]
public partial class RadiantDash : global::FrooxEngine.Component

{
    public global::FrooxEngine.RadiantDashScreen CurrentScreen { get => CurrentScreen_Element.Data; set => CurrentScreen_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantDashScreen>, global::FrooxEngine.RadiantDashScreen> CurrentScreen_Element = new();
public global::System.Boolean Open { get => Open_Element.Data; set => Open_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Open_Element = new();
public global::System.Single AnimationSpeed { get => AnimationSpeed_Element.Data; set => AnimationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnimationSpeed_Element = new();
public global::System.Boolean ScreenProjection { get => ScreenProjection_Element.Data; set => ScreenProjection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScreenProjection_Element = new();
public global::System.Single Curvature { get => Curvature_Element.Data; set => Curvature_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Curvature_Element = new();
public global::FrooxEngine.CurvedPlaneMesh.CurvatureAspectRatioCompensation AspectRatioCompensation { get => AspectRatioCompensation_Element.Data; set => AspectRatioCompensation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CurvedPlaneMesh.CurvatureAspectRatioCompensation>, global::FrooxEngine.CurvedPlaneMesh.CurvatureAspectRatioCompensation> AspectRatioCompensation_Element = new();
public global::System.Boolean ScreenSwitchingEnabled { get => ScreenSwitchingEnabled_Element.Data; set => ScreenSwitchingEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScreenSwitchingEnabled_Element = new();
public global::FrooxEngine.Slot _screensContainer { get => _screensContainer_Element.Data; set => _screensContainer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _screensContainer_Element = new();
public global::FrooxEngine.Camera _camera { get => _camera_Element.Data; set => _camera_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Camera>, global::FrooxEngine.Camera> _camera_Element = new();
public global::FrooxEngine.RenderTextureProvider _renderTexture { get => _renderTexture_Element.Data; set => _renderTexture_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.RenderTextureProvider>, global::FrooxEngine.RenderTextureProvider> _renderTexture_Element = new();
public global::FrooxEngine.Slot _topContainer { get => _topContainer_Element.Data; set => _topContainer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _topContainer_Element = new();
public global::FrooxEngine.CurvedPlaneMesh _topMesh { get => _topMesh_Element.Data; set => _topMesh_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CurvedPlaneMesh>, global::FrooxEngine.CurvedPlaneMesh> _topMesh_Element = new();
public global::FrooxEngine.CurvedPlaneMesh _screenMesh { get => _screenMesh_Element.Data; set => _screenMesh_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CurvedPlaneMesh>, global::FrooxEngine.CurvedPlaneMesh> _screenMesh_Element = new();
public global::FrooxEngine.CurvedPlaneMesh _buttonsMesh { get => _buttonsMesh_Element.Data; set => _buttonsMesh_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CurvedPlaneMesh>, global::FrooxEngine.CurvedPlaneMesh> _buttonsMesh_Element = new();
public global::FrooxEngine.UnlitMaterial _topMaterial { get => _topMaterial_Element.Data; set => _topMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> _topMaterial_Element = new();
public global::FrooxEngine.UnlitMaterial _screenMaterial { get => _screenMaterial_Element.Data; set => _screenMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> _screenMaterial_Element = new();
public global::FrooxEngine.UnlitMaterial _buttonsMaterial { get => _buttonsMaterial_Element.Data; set => _buttonsMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> _buttonsMaterial_Element = new();
public global::FrooxEngine.UI_UnlitMaterial _overlayEffectMaterial { get => _overlayEffectMaterial_Element.Data; set => _overlayEffectMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UI_UnlitMaterial>, global::FrooxEngine.UI_UnlitMaterial> _overlayEffectMaterial_Element = new();
public global::FrooxEngine.UV_RectMaterial _topBorderMaterial { get => _topBorderMaterial_Element.Data; set => _topBorderMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UV_RectMaterial>, global::FrooxEngine.UV_RectMaterial> _topBorderMaterial_Element = new();
public global::FrooxEngine.UV_RectMaterial _screenBorderMaterial { get => _screenBorderMaterial_Element.Data; set => _screenBorderMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UV_RectMaterial>, global::FrooxEngine.UV_RectMaterial> _screenBorderMaterial_Element = new();
public global::FrooxEngine.UV_RectMaterial _buttonsBorderMaterial { get => _buttonsBorderMaterial_Element.Data; set => _buttonsBorderMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UV_RectMaterial>, global::FrooxEngine.UV_RectMaterial> _buttonsBorderMaterial_Element = new();
public global::FrooxEngine.Slot _renderRoot { get => _renderRoot_Element.Data; set => _renderRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _renderRoot_Element = new();
public global::FrooxEngine.Slot _topRoot { get => _topRoot_Element.Data; set => _topRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _topRoot_Element = new();
public global::FrooxEngine.Slot _screenRoot { get => _screenRoot_Element.Data; set => _screenRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _screenRoot_Element = new();
public global::FrooxEngine.Slot _buttonsRoot { get => _buttonsRoot_Element.Data; set => _buttonsRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _buttonsRoot_Element = new();
public global::FrooxEngine.Slot _visualsRoot { get => _visualsRoot_Element.Data; set => _visualsRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visualsRoot_Element = new();
public global::FrooxEngine.Slot _effectRoot { get => _effectRoot_Element.Data; set => _effectRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _effectRoot_Element = new();
public global::FrooxEngine.UIX.Canvas _topCanvas { get => _topCanvas_Element.Data; set => _topCanvas_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Canvas>, global::FrooxEngine.UIX.Canvas> _topCanvas_Element = new();
public global::FrooxEngine.Slot _buttonsUIroot { get => _buttonsUIroot_Element.Data; set => _buttonsUIroot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _buttonsUIroot_Element = new();
public global::FrooxEngine.UIX.Canvas _buttonsCanvas { get => _buttonsCanvas_Element.Data; set => _buttonsCanvas_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Canvas>, global::FrooxEngine.UIX.Canvas> _buttonsCanvas_Element = new();
public global::FrooxEngine.PhotonDust.ParticleStyle _style { get => _style_Element.Data; set => _style_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.ParticleStyle>, global::FrooxEngine.PhotonDust.ParticleStyle> _style_Element = new();
public global::FrooxEngine.PhotonDust.ColorRangeInitializer _particleColors { get => _particleColors_Element.Data; set => _particleColors_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.ColorRangeInitializer>, global::FrooxEngine.PhotonDust.ColorRangeInitializer> _particleColors_Element = new();
public global::FrooxEngine.PhotonDust.MeshEmitter _emitter { get => _emitter_Element.Data; set => _emitter_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.MeshEmitter>, global::FrooxEngine.PhotonDust.MeshEmitter> _emitter_Element = new();
public global::FrooxEngine.MeshCollider _topCollider { get => _topCollider_Element.Data; set => _topCollider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshCollider>, global::FrooxEngine.MeshCollider> _topCollider_Element = new();
public global::FrooxEngine.MeshCollider _screenCollider { get => _screenCollider_Element.Data; set => _screenCollider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshCollider>, global::FrooxEngine.MeshCollider> _screenCollider_Element = new();
public global::FrooxEngine.MeshCollider _buttonsCollider { get => _buttonsCollider_Element.Data; set => _buttonsCollider_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshCollider>, global::FrooxEngine.MeshCollider> _buttonsCollider_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CurrentScreen", CurrentScreen_Element.ToLinkReference(context));
members.Add("Open", Open_Element.ToLinkField(context));
members.Add("AnimationSpeed", AnimationSpeed_Element.ToLinkField(context));
members.Add("ScreenProjection", ScreenProjection_Element.ToLinkField(context));
members.Add("Curvature", Curvature_Element.ToLinkField(context));
members.Add("AspectRatioCompensation", AspectRatioCompensation_Element.ToLinkField(context));
members.Add("ScreenSwitchingEnabled", ScreenSwitchingEnabled_Element.ToLinkField(context));
members.Add("_screensContainer", _screensContainer_Element.ToLinkReference(context));
members.Add("_camera", _camera_Element.ToLinkReference(context));
members.Add("_renderTexture", _renderTexture_Element.ToLinkReference(context));
members.Add("_topContainer", _topContainer_Element.ToLinkReference(context));
members.Add("_topMesh", _topMesh_Element.ToLinkReference(context));
members.Add("_screenMesh", _screenMesh_Element.ToLinkReference(context));
members.Add("_buttonsMesh", _buttonsMesh_Element.ToLinkReference(context));
members.Add("_topMaterial", _topMaterial_Element.ToLinkReference(context));
members.Add("_screenMaterial", _screenMaterial_Element.ToLinkReference(context));
members.Add("_buttonsMaterial", _buttonsMaterial_Element.ToLinkReference(context));
members.Add("_overlayEffectMaterial", _overlayEffectMaterial_Element.ToLinkReference(context));
members.Add("_topBorderMaterial", _topBorderMaterial_Element.ToLinkReference(context));
members.Add("_screenBorderMaterial", _screenBorderMaterial_Element.ToLinkReference(context));
members.Add("_buttonsBorderMaterial", _buttonsBorderMaterial_Element.ToLinkReference(context));
members.Add("_renderRoot", _renderRoot_Element.ToLinkReference(context));
members.Add("_topRoot", _topRoot_Element.ToLinkReference(context));
members.Add("_screenRoot", _screenRoot_Element.ToLinkReference(context));
members.Add("_buttonsRoot", _buttonsRoot_Element.ToLinkReference(context));
members.Add("_visualsRoot", _visualsRoot_Element.ToLinkReference(context));
members.Add("_effectRoot", _effectRoot_Element.ToLinkReference(context));
members.Add("_topCanvas", _topCanvas_Element.ToLinkReference(context));
members.Add("_buttonsUIroot", _buttonsUIroot_Element.ToLinkReference(context));
members.Add("_buttonsCanvas", _buttonsCanvas_Element.ToLinkReference(context));
members.Add("_style", _style_Element.ToLinkReference(context));
members.Add("_particleColors", _particleColors_Element.ToLinkReference(context));
members.Add("_emitter", _emitter_Element.ToLinkReference(context));
members.Add("_topCollider", _topCollider_Element.ToLinkReference(context));
members.Add("_screenCollider", _screenCollider_Element.ToLinkReference(context));
members.Add("_buttonsCollider", _buttonsCollider_Element.ToLinkReference(context));
}

}
}
