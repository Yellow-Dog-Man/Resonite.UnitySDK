
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TransformStreamDriver
// Generated on: čtvrtek 26. února 2026 10:04:49
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TransformStreamDriver")]
public partial class TransformStreamDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.ValueStream<UnityEngine.Vector3> PositionStream { get => PositionStream_Element.Data; set => PositionStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector3>>, global::FrooxEngine.ValueStream<UnityEngine.Vector3>> PositionStream_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Quaternion> RotationStream { get => RotationStream_Element.Data; set => RotationStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Quaternion>>, global::FrooxEngine.ValueStream<UnityEngine.Quaternion>> RotationStream_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> ScaleStream { get => ScaleStream_Element.Data; set => ScaleStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector3>>, global::FrooxEngine.ValueStream<UnityEngine.Vector3>> ScaleStream_Element = new();
public global::FrooxEngine.ReferenceStream<global::FrooxEngine.Slot> RootSpaceStream { get => RootSpaceStream_Element.Data; set => RootSpaceStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ReferenceStream<global::FrooxEngine.Slot>>, global::FrooxEngine.ReferenceStream<global::FrooxEngine.Slot>> RootSpaceStream_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> Rotation { get => Rotation_Element.Data; set => Rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> Rotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Scale_Element = new();
public global::System.Boolean AllowOffsets { get => AllowOffsets_Element.Data; set => AllowOffsets_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowOffsets_Element = new();
public global::System.Boolean ResetStreamsOnDestroy { get => ResetStreamsOnDestroy_Element.Data; set => ResetStreamsOnDestroy_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ResetStreamsOnDestroy_Element = new();
public global::System.Nullable<UnityEngine.Vector3> PositionOffset { get => PositionOffset_Element.Data; set => PositionOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> PositionOffset_Element = new();
public global::System.Nullable<UnityEngine.Quaternion> RotationOffset { get => RotationOffset_Element.Data; set => RotationOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Quaternion>>, global::System.Nullable<UnityEngine.Quaternion>> RotationOffset_Element = new();
public global::System.Nullable<UnityEngine.Vector3> ScaleOffset { get => ScaleOffset_Element.Data; set => ScaleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> ScaleOffset_Element = new();
public global::System.Boolean RunBeforePhysics { get => RunBeforePhysics_Element.Data; set => RunBeforePhysics_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RunBeforePhysics_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionStream", PositionStream_Element.Data.ToResoniteReference(context));
members.Add("RotationStream", RotationStream_Element.Data.ToResoniteReference(context));
members.Add("ScaleStream", ScaleStream_Element.Data.ToResoniteReference(context));
members.Add("RootSpaceStream", RootSpaceStream_Element.Data.ToResoniteReference(context));
members.Add("Position", Position_Element.Data.ToResoniteReference(context));
members.Add("Rotation", Rotation_Element.Data.ToResoniteReference(context));
members.Add("Scale", Scale_Element.Data.ToResoniteReference(context));
members.Add("AllowOffsets", AllowOffsets_Element.Data.ToResoniteLinkField());
members.Add("ResetStreamsOnDestroy", ResetStreamsOnDestroy_Element.Data.ToResoniteLinkField());
members.Add("PositionOffset", PositionOffset_Element.Data.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset_Element.Data.ToResoniteLinkField());
members.Add("ScaleOffset", ScaleOffset_Element.Data.ToResoniteLinkField());
members.Add("RunBeforePhysics", RunBeforePhysics_Element.Data.ToResoniteLinkField());
}

}
}
