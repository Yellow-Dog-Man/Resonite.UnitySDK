
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SingleShaderUI_StencilMaterial
// Generated on: čtvrtek 26. února 2026 15:07:53
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SingleShaderUI_StencilMaterial")]
public abstract partial class SingleShaderUI_StencilMaterial : global::FrooxEngine.UI_StencilMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _shader { get => _shader_Element.Data; set => _shader_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _shader_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_shader", _shader_Element.ToLinkReference(context));
}

}
}
