
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioFilterBlendWrapper
// Generated on: úterý 24. února 2026 18:17:42
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioFilterBlendWrapper")]
public partial class AudioFilterBlendWrapper : global::FrooxEngine.AudioDSP_Effect

{
    public global::System.Single BlendWeight;
public global::FrooxEngine.AudioDSP_Effect NestedFilter;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlendWeight", BlendWeight.ToResoniteLinkField());
members.Add("NestedFilter", NestedFilter.ToResoniteReference(context));
}

}
}
