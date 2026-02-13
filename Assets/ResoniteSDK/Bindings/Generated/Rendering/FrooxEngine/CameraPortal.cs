
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CameraPortal
// Generated on: pátek 13. února 2026 5:52:21
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Renderer", new ResoniteLink.Reference() { });
members.Add("ReflectionTexture", new ResoniteLink.Reference() { });
members.Add("PlaneOffset", PlaneOffset.ToResoniteLinkField());
members.Add("PlaneNormal", PlaneNormal.ToResoniteLinkField());
members.Add("RenderMode", RenderMode.ToResoniteLinkField());
members.Add("PortalTarget", new ResoniteLink.Reference() { });
members.Add("OverrideClear", OverrideClear.ToResoniteLinkField());
members.Add("ClearColor", ClearColor.ToResoniteLinkField());
members.Add("DisablePerPixelLights", DisablePerPixelLights.ToResoniteLinkField());
members.Add("DisableShadows", DisableShadows.ToResoniteLinkField());
members.Add("OverrideFarClip", OverrideFarClip.ToResoniteLinkField());
members.Add("OverrideNearClip", OverrideNearClip.ToResoniteLinkField());
}

}
}
