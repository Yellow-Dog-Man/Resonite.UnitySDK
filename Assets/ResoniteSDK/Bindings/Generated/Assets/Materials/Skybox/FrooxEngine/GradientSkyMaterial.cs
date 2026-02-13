
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GradientSkyMaterial
// Generated on: pátek 13. února 2026 23:21:33
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GradientSkyMaterial")]
public partial class GradientSkyMaterial : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.ISkyboxMaterial

{
    public UnityEngine.ColorX BaseColor;
public System.Collections.Generic.List<global::FrooxEngine.GradientSkyMaterial.Gradient> _gradients;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BaseColor", BaseColor.ToResoniteLinkField());
members.Add("_gradients", new ResoniteLink.SyncList()
{
    Elements = _gradients.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
