
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DiagnosticGaussianSplat
// Generated on: středa 25. února 2026 16:13:04
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
    public global::Renderite.Shared.ColorProfile SplatColorProfile;
public System.Collections.Generic.List<global::FrooxEngine.DiagnosticGaussianSplat.SplatData> Splats;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SplatColorProfile", SplatColorProfile.ToResoniteLinkField());
members.Add("Splats", new ResoniteLink.SyncList()
{
    Elements = Splats.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
