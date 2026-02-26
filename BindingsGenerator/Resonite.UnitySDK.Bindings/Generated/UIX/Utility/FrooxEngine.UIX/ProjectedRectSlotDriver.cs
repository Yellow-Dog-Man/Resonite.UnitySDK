
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ProjectedRectSlotDriver
// Generated on: čtvrtek 26. února 2026 12:28:09
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.Slot Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Target_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation { get => _rotation_Element.Data; set => _rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _scale { get => _scale_Element.Data; set => _scale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _scale_Element = new();
public global::FrooxEngine.Slot _originalParent { get => _originalParent_Element.Data; set => _originalParent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _originalParent_Element = new();
public global::FrooxEngine.Slot _lastTarget { get => _lastTarget_Element.Data; set => _lastTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _lastTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("_rotation", _rotation_Element.ToLinkReference(context));
members.Add("_scale", _scale_Element.ToLinkReference(context));
members.Add("_originalParent", _originalParent_Element.ToLinkReference(context));
members.Add("_lastTarget", _lastTarget_Element.ToLinkReference(context));
}

}
}
