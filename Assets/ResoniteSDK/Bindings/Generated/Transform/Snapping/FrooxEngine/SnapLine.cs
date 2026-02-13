
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapLine
// Generated on: pátek 13. února 2026 5:52:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SnapLine")]
public partial class SnapLine : global::FrooxEngine.Component, global::FrooxEngine.IPointSnappable

{
    public UnityEngine.Vector3 Point0;
public UnityEngine.Vector3 Point1;
public global::FrooxEngine.Slot Anchor0;
public global::FrooxEngine.Slot Anchor1;
public global::FrooxEngine.Slot SnapParent;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Point0", Point0.ToResoniteLinkField());
members.Add("Point1", Point1.ToResoniteLinkField());
members.Add("Anchor0", new ResoniteLink.Reference() { });
members.Add("Anchor1", new ResoniteLink.Reference() { });
members.Add("SnapParent", new ResoniteLink.Reference() { });
}

}
}
