
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MirrorTransform
// Generated on: čtvrtek 26. února 2026 12:28:07
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MirrorTransform")]
public partial class MirrorTransform : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot MirrorSource { get => MirrorSource_Element.Data; set => MirrorSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> MirrorSource_Element = new();
public global::FrooxEngine.Slot MirrorPlane { get => MirrorPlane_Element.Data; set => MirrorPlane_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> MirrorPlane_Element = new();
public UnityEngine.Vector3 MirrorOffset { get => MirrorOffset_Element.Data; set => MirrorOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MirrorOffset_Element = new();
public UnityEngine.Vector3 MirrorNormal { get => MirrorNormal_Element.Data; set => MirrorNormal_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MirrorNormal_Element = new();
public global::System.Boolean AllowWriteBack { get => AllowWriteBack_Element.Data; set => AllowWriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowWriteBack_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _position { get => _position_Element.Data; set => _position_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation { get => _rotation_Element.Data; set => _rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _rotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MirrorSource", MirrorSource_Element.ToLinkReference(context));
members.Add("MirrorPlane", MirrorPlane_Element.ToLinkReference(context));
members.Add("MirrorOffset", MirrorOffset_Element.ToLinkField(context));
members.Add("MirrorNormal", MirrorNormal_Element.ToLinkField(context));
members.Add("AllowWriteBack", AllowWriteBack_Element.ToLinkField(context));
members.Add("_position", _position_Element.ToLinkReference(context));
members.Add("_rotation", _rotation_Element.ToLinkReference(context));
}

}
}
