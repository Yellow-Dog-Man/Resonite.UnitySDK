
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SimplexNoiseHapticFilter
// Generated on: pátek 13. února 2026 23:21:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SimplexNoiseHapticFilter")]
public partial class SimplexNoiseHapticFilter : global::FrooxEngine.HapticFilter

{
    public UnityEngine.Vector3 NoiseScale;
public UnityEngine.Vector3 NoiseOffset;
public global::System.Single MinValue;
public global::System.Single MaxValue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("NoiseScale", NoiseScale.ToResoniteLinkField());
members.Add("NoiseOffset", NoiseOffset.ToResoniteLinkField());
members.Add("MinValue", MinValue.ToResoniteLinkField());
members.Add("MaxValue", MaxValue.ToResoniteLinkField());
}

}
}
