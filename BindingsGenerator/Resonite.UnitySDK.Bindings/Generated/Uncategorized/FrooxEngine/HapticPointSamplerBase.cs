
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticPointSamplerBase
// Generated on: čtvrtek 26. února 2026 12:26:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticPointSamplerBase")]
public abstract partial class HapticPointSamplerBase : global::FrooxEngine.Component

{
    public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Boolean ShowDebugVisual { get => ShowDebugVisual_Element.Data; set => ShowDebugVisual_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowDebugVisual_Element = new();
public global::FrooxEngine.OverlayFresnelMaterial _debugVisual { get => _debugVisual_Element.Data; set => _debugVisual_Element.Data = value; }
public Field<global::FrooxEngine.SlotCleanupRef<global::FrooxEngine.OverlayFresnelMaterial>, global::FrooxEngine.OverlayFresnelMaterial> _debugVisual_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("ShowDebugVisual", ShowDebugVisual_Element.ToLinkField(context));
members.Add("_debugVisual", _debugVisual_Element.ToLinkReference(context));
}

}
}
