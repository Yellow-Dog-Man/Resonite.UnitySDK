
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CameraPortal
// Generated on: čtvrtek 19. února 2026 8:00:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CameraPortal")]
public partial class CameraPortal : global::FrooxEngine.ChangeHandlingRenderableComponent

{
    public global::FrooxEngine.MeshRenderer Renderer;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.RenderTexture> ReflectionTexture;
public global::System.Single PlaneOffset;
public UnityEngine.Vector3 PlaneNormal;
public global::FrooxEngine.CameraPortal.Mode RenderMode;
public global::FrooxEngine.Slot PortalTarget;
public global::System.Nullable<global::Renderite.Shared.CameraClearMode> OverrideClear;
public UnityEngine.ColorX ClearColor;
public global::System.Boolean DisablePerPixelLights;
public global::System.Boolean DisableShadows;
public global::System.Nullable<global::System.Single> OverrideFarClip;
public global::System.Nullable<global::System.Single> OverrideNearClip;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Renderer", Renderer.ToResoniteReference(context));
members.Add("ReflectionTexture", ReflectionTexture.ToResoniteReference(context));
members.Add("PlaneOffset", PlaneOffset.ToResoniteLinkField());
members.Add("PlaneNormal", PlaneNormal.ToResoniteLinkField());
members.Add("RenderMode", RenderMode.ToResoniteLinkField());
members.Add("PortalTarget", PortalTarget.ToResoniteReference(context));
members.Add("OverrideClear", OverrideClear.ToResoniteLinkField());
members.Add("ClearColor", ClearColor.ToResoniteLinkField());
members.Add("DisablePerPixelLights", DisablePerPixelLights.ToResoniteLinkField());
members.Add("DisableShadows", DisableShadows.ToResoniteLinkField());
members.Add("OverrideFarClip", OverrideFarClip.ToResoniteLinkField());
members.Add("OverrideNearClip", OverrideNearClip.ToResoniteLinkField());
}

}
}
