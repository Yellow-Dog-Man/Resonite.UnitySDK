
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapPlane
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SnapPlane")]
public partial class SnapPlane : global::FrooxEngine.Component, global::FrooxEngine.IPointSnappable, global::FrooxEngine.IUIInterface

{
    public UnityEngine.Vector3 Normal;
public global::FrooxEngine.Slot SnapParent;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Normal", Normal.ToResoniteLinkField());
members.Add("SnapParent", new ResoniteLink.Reference() { });
}

}
}
