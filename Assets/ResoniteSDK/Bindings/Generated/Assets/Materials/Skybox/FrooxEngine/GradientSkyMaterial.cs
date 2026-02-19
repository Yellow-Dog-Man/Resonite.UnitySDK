
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GradientSkyMaterial
// Generated on: čtvrtek 19. února 2026 7:58:51
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseColor", BaseColor.ToResoniteLinkField());
members.Add("_gradients", new ResoniteLink.SyncList()
{
    Elements = _gradients.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
