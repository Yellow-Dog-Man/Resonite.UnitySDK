
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CurvePoint
// Generated on: pátek 13. února 2026 5:52:29
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CurvePoint")]
public partial class CurvePoint : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot LeftTangentSource;
public global::FrooxEngine.Slot RightTangentSource;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LeftTangentSource", new ResoniteLink.Reference() { });
members.Add("RightTangentSource", new ResoniteLink.Reference() { });
}

}
}
