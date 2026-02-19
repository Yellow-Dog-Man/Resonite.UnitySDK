
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HeadHapticPointMapper
// Generated on: čtvrtek 19. února 2026 7:58:58
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HeadHapticPointMapper")]
public partial class HeadHapticPointMapper : global::FrooxEngine.HapticPointMapper

{
    public UnityEngine.Vector3 HeadSize;
public UnityEngine.Vector3 HeadCenter;
public global::FrooxEngine.Slot _debugVisual;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HeadSize", HeadSize.ToResoniteLinkField());
members.Add("HeadCenter", HeadCenter.ToResoniteLinkField());
members.Add("_debugVisual", _debugVisual.ToResoniteReference(context));
}

}
}
