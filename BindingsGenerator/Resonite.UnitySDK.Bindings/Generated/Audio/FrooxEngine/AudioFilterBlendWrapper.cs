
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioFilterBlendWrapper
// Generated on: středa 25. února 2026 16:13:05
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
