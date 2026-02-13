
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionProbe
// Generated on: pátek 13. února 2026 5:52:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReflectionProbe")]
public partial class ReflectionProbe : global::FrooxEngine.ChangeHandlingRenderableComponent

{
    public global::Renderite.Shared.ReflectionProbeType ProbeType;
public global::System.Int32 Importance;
public global::System.Single Intensity;
public global::System.Single BlendDistance;
public UnityEngine.Vector3 BoxSize;
public global::System.Boolean BoxProjection;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Cubemap> BakedCubemap;
public System.Collections.Generic.List<global::FrooxEngine.IChangeable> ChangesSources;
public global::Renderite.Shared.ReflectionProbeTimeSlicingMode TimeSlicing;
public global::System.Int32 Resolution;
public global::System.Boolean HDR;
public global::System.Single ShadowDistance;
public global::Renderite.Shared.ReflectionProbeClear ClearFlags;
public UnityEngine.ColorX BackgroundColor;
public global::System.Single NearClip;
public global::System.Single FarClip;
public global::System.Boolean SkyboxOnly;
public global::System.Boolean ShowDebugVisuals;
public global::FrooxEngine.Slot _debugVisual;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ProbeType", ProbeType.ToResoniteLinkField());
members.Add("Importance", Importance.ToResoniteLinkField());
members.Add("Intensity", Intensity.ToResoniteLinkField());
members.Add("BlendDistance", BlendDistance.ToResoniteLinkField());
members.Add("BoxSize", BoxSize.ToResoniteLinkField());
members.Add("BoxProjection", BoxProjection.ToResoniteLinkField());
members.Add("BakedCubemap", new ResoniteLink.Reference() { });
members.Add("ChangesSources", new ResoniteLink.SyncList()
{
    Elements = ChangesSources.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("TimeSlicing", TimeSlicing.ToResoniteLinkField());
members.Add("Resolution", Resolution.ToResoniteLinkField());
members.Add("HDR", HDR.ToResoniteLinkField());
members.Add("ShadowDistance", ShadowDistance.ToResoniteLinkField());
members.Add("ClearFlags", ClearFlags.ToResoniteLinkField());
members.Add("BackgroundColor", BackgroundColor.ToResoniteLinkField());
members.Add("NearClip", NearClip.ToResoniteLinkField());
members.Add("FarClip", FarClip.ToResoniteLinkField());
members.Add("SkyboxOnly", SkyboxOnly.ToResoniteLinkField());
members.Add("ShowDebugVisuals", ShowDebugVisuals.ToResoniteLinkField());
members.Add("_debugVisual", new ResoniteLink.Reference() { });
}

}
}
