
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionProbe
// Generated on: čtvrtek 26. února 2026 15:08:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReflectionProbe")]
public partial class ReflectionProbe : global::FrooxEngine.ChangeHandlingRenderableComponent

{
    public global::Renderite.Shared.ReflectionProbeType ProbeType { get => ProbeType_Element.Data; set => ProbeType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ReflectionProbeType>, global::Renderite.Shared.ReflectionProbeType> ProbeType_Element = new();
public global::System.Int32 Importance { get => Importance_Element.Data; set => Importance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Importance_Element = new();
public global::System.Single Intensity { get => Intensity_Element.Data; set => Intensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Intensity_Element = new();
public global::System.Single BlendDistance { get => BlendDistance_Element.Data; set => BlendDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlendDistance_Element = new();
public UnityEngine.Vector3 BoxSize { get => BoxSize_Element.Data; set => BoxSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> BoxSize_Element = new();
public global::System.Boolean BoxProjection { get => BoxProjection_Element.Data; set => BoxProjection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> BoxProjection_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap> BakedCubemap { get => BakedCubemap_Element.Data; set => BakedCubemap_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Cubemap>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap>> BakedCubemap_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.RelayEventRef<global::FrooxEngine.IChangeable>>, global::FrooxEngine.IChangeable, Reference<global::FrooxEngine.RelayEventRef<global::FrooxEngine.IChangeable>, global::FrooxEngine.IChangeable>> ChangesSources = new();
public global::Renderite.Shared.ReflectionProbeTimeSlicingMode TimeSlicing { get => TimeSlicing_Element.Data; set => TimeSlicing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ReflectionProbeTimeSlicingMode>, global::Renderite.Shared.ReflectionProbeTimeSlicingMode> TimeSlicing_Element = new();
public global::System.Int32 Resolution { get => Resolution_Element.Data; set => Resolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Resolution_Element = new();
public global::System.Boolean HDR { get => HDR_Element.Data; set => HDR_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> HDR_Element = new();
public global::System.Single ShadowDistance { get => ShadowDistance_Element.Data; set => ShadowDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ShadowDistance_Element = new();
public global::Renderite.Shared.ReflectionProbeClear ClearFlags { get => ClearFlags_Element.Data; set => ClearFlags_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ReflectionProbeClear>, global::Renderite.Shared.ReflectionProbeClear> ClearFlags_Element = new();
public UnityEngine.ColorX BackgroundColor { get => BackgroundColor_Element.Data; set => BackgroundColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BackgroundColor_Element = new();
public global::System.Single NearClip { get => NearClip_Element.Data; set => NearClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NearClip_Element = new();
public global::System.Single FarClip { get => FarClip_Element.Data; set => FarClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FarClip_Element = new();
public global::System.Boolean SkyboxOnly { get => SkyboxOnly_Element.Data; set => SkyboxOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SkyboxOnly_Element = new();
public global::System.Boolean ShowDebugVisuals { get => ShowDebugVisuals_Element.Data; set => ShowDebugVisuals_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowDebugVisuals_Element = new();
public global::FrooxEngine.Slot _debugVisual { get => _debugVisual_Element.Data; set => _debugVisual_Element.Data = value; }
public Reference<global::FrooxEngine.SlotCleanupRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _debugVisual_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ProbeType", ProbeType_Element.ToLinkField(context));
members.Add("Importance", Importance_Element.ToLinkField(context));
members.Add("Intensity", Intensity_Element.ToLinkField(context));
members.Add("BlendDistance", BlendDistance_Element.ToLinkField(context));
members.Add("BoxSize", BoxSize_Element.ToLinkField(context));
members.Add("BoxProjection", BoxProjection_Element.ToLinkField(context));
members.Add("BakedCubemap", BakedCubemap_Element.ToLinkReference(context));
members.Add("ChangesSources", ChangesSources.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("TimeSlicing", TimeSlicing_Element.ToLinkField(context));
members.Add("Resolution", Resolution_Element.ToLinkField(context));
members.Add("HDR", HDR_Element.ToLinkField(context));
members.Add("ShadowDistance", ShadowDistance_Element.ToLinkField(context));
members.Add("ClearFlags", ClearFlags_Element.ToLinkField(context));
members.Add("BackgroundColor", BackgroundColor_Element.ToLinkField(context));
members.Add("NearClip", NearClip_Element.ToLinkField(context));
members.Add("FarClip", FarClip_Element.ToLinkField(context));
members.Add("SkyboxOnly", SkyboxOnly_Element.ToLinkField(context));
members.Add("ShowDebugVisuals", ShowDebugVisuals_Element.ToLinkField(context));
members.Add("_debugVisual", _debugVisual_Element.ToLinkReference(context));
}

}
}
