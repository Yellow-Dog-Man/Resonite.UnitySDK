
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GradientSkyMaterial
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GradientSkyMaterial")]
public partial class GradientSkyMaterial : global::FrooxEngine.SingleShaderMaterialProvider, global::FrooxEngine.ISkyboxMaterial

{
    public UnityEngine.ColorX BaseColor { get => BaseColor_Element.Data; set => BaseColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BaseColor_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.GradientSkyMaterial.Gradient>, global::FrooxEngine.GradientSkyMaterial.Gradient> _gradients = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseColor", BaseColor_Element.ToLinkField(context));
members.Add("_gradients", _gradients.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
