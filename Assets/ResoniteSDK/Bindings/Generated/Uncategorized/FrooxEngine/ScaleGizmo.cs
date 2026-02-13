
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleGizmo
// Generated on: pátek 13. února 2026 23:23:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleGizmo")]
public partial class ScaleGizmo : global::FrooxEngine.Gizmo

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> TargetScale;
public global::System.Single HandleLength;
public global::FrooxEngine.Slot _xSlot;
public global::FrooxEngine.Slot _ySlot;
public global::FrooxEngine.Slot _zSlot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetScale", new ResoniteLink.Reference() { });
members.Add("HandleLength", HandleLength.ToResoniteLinkField());
members.Add("_xSlot", new ResoniteLink.Reference() { });
members.Add("_ySlot", new ResoniteLink.Reference() { });
members.Add("_zSlot", new ResoniteLink.Reference() { });
}

}
}
