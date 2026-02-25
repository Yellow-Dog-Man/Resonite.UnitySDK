
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticPointSamplerBase
// Generated on: středa 25. února 2026 16:13:09
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
