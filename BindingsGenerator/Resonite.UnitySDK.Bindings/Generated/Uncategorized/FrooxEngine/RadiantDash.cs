
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RadiantDash
// Generated on: středa 25. února 2026 16:14:37
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CurrentScreen", CurrentScreen.ToResoniteReference(context));
members.Add("Open", Open.ToResoniteLinkField());
members.Add("AnimationSpeed", AnimationSpeed.ToResoniteLinkField());
members.Add("ScreenProjection", ScreenProjection.ToResoniteLinkField());
members.Add("Curvature", Curvature.ToResoniteLinkField());
members.Add("AspectRatioCompensation", AspectRatioCompensation.ToResoniteLinkField());
members.Add("ScreenSwitchingEnabled", ScreenSwitchingEnabled.ToResoniteLinkField());
members.Add("_screensContainer", _screensContainer.ToResoniteReference(context));
members.Add("_camera", _camera.ToResoniteReference(context));
members.Add("_renderTexture", _renderTexture.ToResoniteReference(context));
members.Add("_topContainer", _topContainer.ToResoniteReference(context));
members.Add("_topMesh", _topMesh.ToResoniteReference(context));
members.Add("_screenMesh", _screenMesh.ToResoniteReference(context));
members.Add("_buttonsMesh", _buttonsMesh.ToResoniteReference(context));
members.Add("_topMaterial", _topMaterial.ToResoniteReference(context));
members.Add("_screenMaterial", _screenMaterial.ToResoniteReference(context));
members.Add("_buttonsMaterial", _buttonsMaterial.ToResoniteReference(context));
members.Add("_overlayEffectMaterial", _overlayEffectMaterial.ToResoniteReference(context));
members.Add("_topBorderMaterial", _topBorderMaterial.ToResoniteReference(context));
members.Add("_screenBorderMaterial", _screenBorderMaterial.ToResoniteReference(context));
members.Add("_buttonsBorderMaterial", _buttonsBorderMaterial.ToResoniteReference(context));
members.Add("_renderRoot", _renderRoot.ToResoniteReference(context));
members.Add("_topRoot", _topRoot.ToResoniteReference(context));
members.Add("_screenRoot", _screenRoot.ToResoniteReference(context));
members.Add("_buttonsRoot", _buttonsRoot.ToResoniteReference(context));
members.Add("_visualsRoot", _visualsRoot.ToResoniteReference(context));
members.Add("_effectRoot", _effectRoot.ToResoniteReference(context));
members.Add("_topCanvas", _topCanvas.ToResoniteReference(context));
members.Add("_buttonsUIroot", _buttonsUIroot.ToResoniteReference(context));
members.Add("_buttonsCanvas", _buttonsCanvas.ToResoniteReference(context));
members.Add("_style", _style.ToResoniteReference(context));
members.Add("_particleColors", _particleColors.ToResoniteReference(context));
members.Add("_emitter", _emitter.ToResoniteReference(context));
members.Add("_topCollider", _topCollider.ToResoniteReference(context));
members.Add("_screenCollider", _screenCollider.ToResoniteReference(context));
members.Add("_buttonsCollider", _buttonsCollider.ToResoniteReference(context));
}

}
}
