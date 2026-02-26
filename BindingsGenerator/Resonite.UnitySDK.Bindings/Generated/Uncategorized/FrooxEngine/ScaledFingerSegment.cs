
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaledFingerSegment
// Generated on: čtvrtek 26. února 2026 15:09:14
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaledFingerSegment")]
public partial class ScaledFingerSegment : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> _scale { get => _scale_Element.Data; set => _scale_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _scale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _offset { get => _offset_Element.Data; set => _offset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _offset_Element = new();
public global::FrooxEngine.Slot _nextJoint { get => _nextJoint_Element.Data; set => _nextJoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _nextJoint_Element = new();
public global::Renderite.Shared.BodyNode _bodyNode { get => _bodyNode_Element.Data; set => _bodyNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.BodyNode>, global::Renderite.Shared.BodyNode> _bodyNode_Element = new();
public global::System.Single Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Width_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_scale", _scale_Element.ToLinkReference(context));
members.Add("_offset", _offset_Element.ToLinkReference(context));
members.Add("_nextJoint", _nextJoint_Element.ToLinkReference(context));
members.Add("_bodyNode", _bodyNode_Element.ToLinkField(context));
members.Add("Width", Width_Element.ToLinkField(context));
}

}
}
