
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SingleShaderMaterialProvider
// Generated on: čtvrtek 26. února 2026 12:26:47
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SingleShaderMaterialProvider")]
public abstract partial class SingleShaderMaterialProvider : global::FrooxEngine.MaterialProvider

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _shader { get => _shader_Element.Data; set => _shader_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.Shader>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader>> _shader_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_shader", _shader_Element.ToLinkReference(context));
}

}
}
