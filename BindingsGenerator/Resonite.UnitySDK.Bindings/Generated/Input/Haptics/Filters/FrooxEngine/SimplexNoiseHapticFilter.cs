
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SimplexNoiseHapticFilter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SimplexNoiseHapticFilter")]
public partial class SimplexNoiseHapticFilter : global::FrooxEngine.HapticFilter

{
    public UnityEngine.Vector3 NoiseScale;
public UnityEngine.Vector3 NoiseOffset;
public global::System.Single MinValue;
public global::System.Single MaxValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NoiseScale", NoiseScale.ToResoniteLinkField());
members.Add("NoiseOffset", NoiseOffset.ToResoniteLinkField());
members.Add("MinValue", MinValue.ToResoniteLinkField());
members.Add("MaxValue", MaxValue.ToResoniteLinkField());
}

}
}
