
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DiagnosticGaussianSplat
// Generated on: pátek 13. února 2026 5:51:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DiagnosticGaussianSplat")]
public partial class DiagnosticGaussianSplat : global::FrooxEngine.ProceduralGaussianSplat

{
    public global::Renderite.Shared.ColorProfile SplatColorProfile;
public System.Collections.Generic.List<global::FrooxEngine.DiagnosticGaussianSplat.SplatData> Splats;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SplatColorProfile", SplatColorProfile.ToResoniteLinkField());
members.Add("Splats", new ResoniteLink.SyncList()
{
    Elements = Splats.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
}

}
}
