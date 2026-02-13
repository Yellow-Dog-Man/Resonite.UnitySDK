
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HeadHapticPointMapper
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HeadHapticPointMapper")]
public partial class HeadHapticPointMapper : global::FrooxEngine.HapticPointMapper

{
    public UnityEngine.Vector3 HeadSize;
public UnityEngine.Vector3 HeadCenter;
public global::FrooxEngine.Slot _debugVisual;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("HeadSize", HeadSize.ToResoniteLinkField());
members.Add("HeadCenter", HeadCenter.ToResoniteLinkField());
members.Add("_debugVisual", new ResoniteLink.Reference() { });
}

}
}
