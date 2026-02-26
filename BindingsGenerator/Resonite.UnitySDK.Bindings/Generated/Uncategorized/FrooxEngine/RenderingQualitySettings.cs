
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderingQualitySettings
// Generated on: čtvrtek 26. února 2026 15:09:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RenderingQualitySettings")]
public partial class RenderingQualitySettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.RenderingQualitySettings>

{
    public global::System.Int32 PerPixelLights { get => PerPixelLights_Element.Data; set => PerPixelLights_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> PerPixelLights_Element = new();
public global::Renderite.Shared.ShadowCascadeMode ShadowCascades { get => ShadowCascades_Element.Data; set => ShadowCascades_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ShadowCascadeMode>, global::Renderite.Shared.ShadowCascadeMode> ShadowCascades_Element = new();
public global::Renderite.Shared.ShadowResolutionMode ShadowResolution { get => ShadowResolution_Element.Data; set => ShadowResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ShadowResolutionMode>, global::Renderite.Shared.ShadowResolutionMode> ShadowResolution_Element = new();
public global::System.Single ShadowDistance { get => ShadowDistance_Element.Data; set => ShadowDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowDistance_Element = new();
public global::Renderite.Shared.SkinWeightMode SkinWeightMode { get => SkinWeightMode_Element.Data; set => SkinWeightMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.SkinWeightMode>, global::Renderite.Shared.SkinWeightMode> SkinWeightMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PerPixelLights", PerPixelLights_Element.ToLinkField(context));
members.Add("ShadowCascades", ShadowCascades_Element.ToLinkField(context));
members.Add("ShadowResolution", ShadowResolution_Element.ToLinkField(context));
members.Add("ShadowDistance", ShadowDistance_Element.ToLinkField(context));
members.Add("SkinWeightMode", SkinWeightMode_Element.ToLinkField(context));
}

}
}
