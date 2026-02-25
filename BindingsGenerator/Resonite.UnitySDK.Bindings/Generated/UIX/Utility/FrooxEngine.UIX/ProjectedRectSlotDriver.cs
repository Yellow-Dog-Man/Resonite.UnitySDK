
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ProjectedRectSlotDriver
// Generated on: středa 25. února 2026 16:14:34
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("_rotation", _rotation.ToResoniteReference(context));
members.Add("_scale", _scale.ToResoniteReference(context));
members.Add("_originalParent", _originalParent.ToResoniteReference(context));
members.Add("_lastTarget", _lastTarget.ToResoniteReference(context));
}

}
}
