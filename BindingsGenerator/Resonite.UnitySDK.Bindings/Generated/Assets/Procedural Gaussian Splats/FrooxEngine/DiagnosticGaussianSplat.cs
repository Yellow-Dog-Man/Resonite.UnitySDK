
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DiagnosticGaussianSplat
// Generated on: čtvrtek 26. února 2026 10:03:35
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
members.Add("SplatColorProfile", SplatColorProfile_Element.Data.ToResoniteLinkField());
members.Add("Splats", new ResoniteLink.SyncList()
{
    Elements = Splats.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
