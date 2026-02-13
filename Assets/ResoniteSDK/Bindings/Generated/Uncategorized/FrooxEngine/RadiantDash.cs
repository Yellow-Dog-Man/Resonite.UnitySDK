
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDash
// Generated on: pátek 13. února 2026 5:52:30
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RadiantDash")]
public partial class RadiantDash : global::FrooxEngine.Component

{
    public global::FrooxEngine.RadiantDashScreen CurrentScreen;
public global::System.Boolean Open;
public global::System.Single AnimationSpeed;
public global::System.Boolean ScreenProjection;
public global::System.Single Curvature;
public global::FrooxEngine.CurvedPlaneMesh.CurvatureAspectRatioCompensation AspectRatioCompensation;
public global::System.Boolean ScreenSwitchingEnabled;
public global::FrooxEngine.Slot _screensContainer;
public global::FrooxEngine.Camera _camera;
public global::FrooxEngine.RenderTextureProvider _renderTexture;
public global::FrooxEngine.Slot _topContainer;
public global::FrooxEngine.CurvedPlaneMesh _topMesh;
public global::FrooxEngine.CurvedPlaneMesh _screenMesh;
public global::FrooxEngine.CurvedPlaneMesh _buttonsMesh;
public global::FrooxEngine.UnlitMaterial _topMaterial;
public global::FrooxEngine.UnlitMaterial _screenMaterial;
public global::FrooxEngine.UnlitMaterial _buttonsMaterial;
public global::FrooxEngine.UI_UnlitMaterial _overlayEffectMaterial;
public global::FrooxEngine.UV_RectMaterial _topBorderMaterial;
public global::FrooxEngine.UV_RectMaterial _screenBorderMaterial;
public global::FrooxEngine.UV_RectMaterial _buttonsBorderMaterial;
public global::FrooxEngine.Slot _renderRoot;
public global::FrooxEngine.Slot _topRoot;
public global::FrooxEngine.Slot _screenRoot;
public global::FrooxEngine.Slot _buttonsRoot;
public global::FrooxEngine.Slot _visualsRoot;
public global::FrooxEngine.Slot _effectRoot;
public global::FrooxEngine.UIX.Canvas _topCanvas;
public global::FrooxEngine.Slot _buttonsUIroot;
public global::FrooxEngine.UIX.Canvas _buttonsCanvas;
public global::FrooxEngine.PhotonDust.ParticleStyle _style;
public global::FrooxEngine.PhotonDust.ColorRangeInitializer _particleColors;
public global::FrooxEngine.PhotonDust.MeshEmitter _emitter;
public global::FrooxEngine.MeshCollider _topCollider;
public global::FrooxEngine.MeshCollider _screenCollider;
public global::FrooxEngine.MeshCollider _buttonsCollider;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CurrentScreen", new ResoniteLink.Reference() { });
members.Add("Open", Open.ToResoniteLinkField());
members.Add("AnimationSpeed", AnimationSpeed.ToResoniteLinkField());
members.Add("ScreenProjection", ScreenProjection.ToResoniteLinkField());
members.Add("Curvature", Curvature.ToResoniteLinkField());
members.Add("AspectRatioCompensation", AspectRatioCompensation.ToResoniteLinkField());
members.Add("ScreenSwitchingEnabled", ScreenSwitchingEnabled.ToResoniteLinkField());
members.Add("_screensContainer", new ResoniteLink.Reference() { });
members.Add("_camera", new ResoniteLink.Reference() { });
members.Add("_renderTexture", new ResoniteLink.Reference() { });
members.Add("_topContainer", new ResoniteLink.Reference() { });
members.Add("_topMesh", new ResoniteLink.Reference() { });
members.Add("_screenMesh", new ResoniteLink.Reference() { });
members.Add("_buttonsMesh", new ResoniteLink.Reference() { });
members.Add("_topMaterial", new ResoniteLink.Reference() { });
members.Add("_screenMaterial", new ResoniteLink.Reference() { });
members.Add("_buttonsMaterial", new ResoniteLink.Reference() { });
members.Add("_overlayEffectMaterial", new ResoniteLink.Reference() { });
members.Add("_topBorderMaterial", new ResoniteLink.Reference() { });
members.Add("_screenBorderMaterial", new ResoniteLink.Reference() { });
members.Add("_buttonsBorderMaterial", new ResoniteLink.Reference() { });
members.Add("_renderRoot", new ResoniteLink.Reference() { });
members.Add("_topRoot", new ResoniteLink.Reference() { });
members.Add("_screenRoot", new ResoniteLink.Reference() { });
members.Add("_buttonsRoot", new ResoniteLink.Reference() { });
members.Add("_visualsRoot", new ResoniteLink.Reference() { });
members.Add("_effectRoot", new ResoniteLink.Reference() { });
members.Add("_topCanvas", new ResoniteLink.Reference() { });
members.Add("_buttonsUIroot", new ResoniteLink.Reference() { });
members.Add("_buttonsCanvas", new ResoniteLink.Reference() { });
members.Add("_style", new ResoniteLink.Reference() { });
members.Add("_particleColors", new ResoniteLink.Reference() { });
members.Add("_emitter", new ResoniteLink.Reference() { });
members.Add("_topCollider", new ResoniteLink.Reference() { });
members.Add("_screenCollider", new ResoniteLink.Reference() { });
members.Add("_buttonsCollider", new ResoniteLink.Reference() { });
}

}
}
