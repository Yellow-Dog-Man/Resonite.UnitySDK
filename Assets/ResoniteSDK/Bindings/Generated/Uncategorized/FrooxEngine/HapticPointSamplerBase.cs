
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticPointSamplerBase
// Generated on: úterý 24. února 2026 18:17:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticPointSamplerBase")]
public abstract partial class HapticPointSamplerBase : global::FrooxEngine.Component

{
    public global::System.Single Radius;
public global::System.Boolean ShowDebugVisual;
public global::FrooxEngine.OverlayFresnelMaterial _debugVisual;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("ShowDebugVisual", ShowDebugVisual.ToResoniteLinkField());
members.Add("_debugVisual", _debugVisual.ToResoniteReference(context));
}

}
}
