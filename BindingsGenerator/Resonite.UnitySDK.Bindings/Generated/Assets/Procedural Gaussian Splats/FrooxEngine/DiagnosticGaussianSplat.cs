
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DiagnosticGaussianSplat
// Generated on: pátek 6. března 2026 14:18:04
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DiagnosticGaussianSplat")]
public partial class DiagnosticGaussianSplat : global::FrooxEngine.ProceduralGaussianSplat

{
    public global::Renderite.Shared.ColorProfile SplatColorProfile { get => SplatColorProfile_Element.Data; set => SplatColorProfile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ColorProfile>, global::Renderite.Shared.ColorProfile> SplatColorProfile_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.DiagnosticGaussianSplat.SplatData>, global::FrooxEngine.DiagnosticGaussianSplat.SplatData> Splats = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SplatColorProfile", SplatColorProfile_Element.ToLinkField(context));
members.Add("Splats", Splats.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
