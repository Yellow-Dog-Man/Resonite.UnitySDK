
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SingleShaderUI_StencilMaterial
// Generated on: středa 25. února 2026 16:13:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SingleShaderUI_StencilMaterial")]
public abstract partial class SingleShaderUI_StencilMaterial : global::FrooxEngine.UI_StencilMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _shader;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_shader", _shader.ToResoniteReference(context));
}

}
}
