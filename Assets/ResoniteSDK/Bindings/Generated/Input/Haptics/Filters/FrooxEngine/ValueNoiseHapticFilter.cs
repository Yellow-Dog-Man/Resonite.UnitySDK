
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueNoiseHapticFilter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueNoiseHapticFilter")]
public partial class ValueNoiseHapticFilter : global::FrooxEngine.HapticFilter

{
    public global::System.Single MinValue;
public global::System.Single MaxValue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MinValue", MinValue.ToResoniteLinkField());
members.Add("MaxValue", MaxValue.ToResoniteLinkField());
}

}
}
