
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CameraPortal
// Generated on: čtvrtek 26. února 2026 15:09:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CameraPortal")]
public partial class CameraPortal : global::FrooxEngine.ChangeHandlingRenderableComponent

{
    public global::FrooxEngine.MeshRenderer Renderer { get => Renderer_Element.Data; set => Renderer_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> Renderer_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.RenderTexture> ReflectionTexture { get => ReflectionTexture_Element.Data; set => ReflectionTexture_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.RenderTexture>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.RenderTexture>> ReflectionTexture_Element = new();
public global::System.Single PlaneOffset { get => PlaneOffset_Element.Data; set => PlaneOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PlaneOffset_Element = new();
public UnityEngine.Vector3 PlaneNormal { get => PlaneNormal_Element.Data; set => PlaneNormal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> PlaneNormal_Element = new();
public global::FrooxEngine.CameraPortal.Mode RenderMode { get => RenderMode_Element.Data; set => RenderMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CameraPortal.Mode>, global::FrooxEngine.CameraPortal.Mode> RenderMode_Element = new();
public global::FrooxEngine.Slot PortalTarget { get => PortalTarget_Element.Data; set => PortalTarget_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> PortalTarget_Element = new();
public global::System.Nullable<global::Renderite.Shared.CameraClearMode> OverrideClear { get => OverrideClear_Element.Data; set => OverrideClear_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::Renderite.Shared.CameraClearMode>>, global::System.Nullable<global::Renderite.Shared.CameraClearMode>> OverrideClear_Element = new();
public UnityEngine.ColorX ClearColor { get => ClearColor_Element.Data; set => ClearColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> ClearColor_Element = new();
public global::System.Boolean DisablePerPixelLights { get => DisablePerPixelLights_Element.Data; set => DisablePerPixelLights_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DisablePerPixelLights_Element = new();
public global::System.Boolean DisableShadows { get => DisableShadows_Element.Data; set => DisableShadows_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DisableShadows_Element = new();
public global::System.Nullable<global::System.Single> OverrideFarClip { get => OverrideFarClip_Element.Data; set => OverrideFarClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> OverrideFarClip_Element = new();
public global::System.Nullable<global::System.Single> OverrideNearClip { get => OverrideNearClip_Element.Data; set => OverrideNearClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> OverrideNearClip_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Renderer", Renderer_Element.ToLinkReference(context));
members.Add("ReflectionTexture", ReflectionTexture_Element.ToLinkReference(context));
members.Add("PlaneOffset", PlaneOffset_Element.ToLinkField(context));
members.Add("PlaneNormal", PlaneNormal_Element.ToLinkField(context));
members.Add("RenderMode", RenderMode_Element.ToLinkField(context));
members.Add("PortalTarget", PortalTarget_Element.ToLinkReference(context));
members.Add("OverrideClear", OverrideClear_Element.ToLinkField(context));
members.Add("ClearColor", ClearColor_Element.ToLinkField(context));
members.Add("DisablePerPixelLights", DisablePerPixelLights_Element.ToLinkField(context));
members.Add("DisableShadows", DisableShadows_Element.ToLinkField(context));
members.Add("OverrideFarClip", OverrideFarClip_Element.ToLinkField(context));
members.Add("OverrideNearClip", OverrideNearClip_Element.ToLinkField(context));
}

}
}
