
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ProjectedRectSlotDriver
// Generated on: pátek 13. února 2026 23:23:12
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ProjectedRectSlotDriver")]
public partial class ProjectedRectSlotDriver : global::FrooxEngine.UIX.RectSlotDriver

{
    public global::FrooxEngine.Slot Target;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _scale;
public global::FrooxEngine.Slot _originalParent;
public global::FrooxEngine.Slot _lastTarget;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("_rotation", new ResoniteLink.Reference() { });
members.Add("_scale", new ResoniteLink.Reference() { });
members.Add("_originalParent", new ResoniteLink.Reference() { });
members.Add("_lastTarget", new ResoniteLink.Reference() { });
}

}
}
