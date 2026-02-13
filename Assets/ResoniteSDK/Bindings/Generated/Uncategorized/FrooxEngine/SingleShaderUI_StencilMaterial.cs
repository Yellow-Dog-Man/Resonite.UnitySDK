
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SingleShaderUI_StencilMaterial
// Generated on: pátek 13. února 2026 23:21:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SingleShaderUI_StencilMaterial")]
public abstract partial class SingleShaderUI_StencilMaterial : global::FrooxEngine.UI_StencilMaterial

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _shader;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_shader", new ResoniteLink.Reference() { });
}

}
}
