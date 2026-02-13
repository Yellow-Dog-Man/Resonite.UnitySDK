
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapSphere
// Generated on: pátek 13. února 2026 23:23:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SnapSphere")]
public partial class SnapSphere : global::FrooxEngine.Component, global::FrooxEngine.IPointSnappable

{
    public global::System.Single Radius;
public global::FrooxEngine.Slot SnapParent;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("SnapParent", new ResoniteLink.Reference() { });
}

}
}
