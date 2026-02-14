
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TransformStreamDriver
// Generated on: sobota 14. února 2026 8:58:49
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TransformStreamDriver")]
public partial class TransformStreamDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.ValueStream<UnityEngine.Vector3> PositionStream;
public global::FrooxEngine.ValueStream<UnityEngine.Quaternion> RotationStream;
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> ScaleStream;
public global::FrooxEngine.ReferenceStream<global::FrooxEngine.Slot> RootSpaceStream;
public global::FrooxEngine.IField<UnityEngine.Vector3> Position;
public global::FrooxEngine.IField<UnityEngine.Quaternion> Rotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> Scale;
public global::System.Boolean AllowOffsets;
public global::System.Boolean ResetStreamsOnDestroy;
public global::System.Nullable<UnityEngine.Vector3> PositionOffset;
public global::System.Nullable<UnityEngine.Quaternion> RotationOffset;
public global::System.Nullable<UnityEngine.Vector3> ScaleOffset;
public global::System.Boolean RunBeforePhysics;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionStream", PositionStream.ToResoniteReference(context));
members.Add("RotationStream", RotationStream.ToResoniteReference(context));
members.Add("ScaleStream", ScaleStream.ToResoniteReference(context));
members.Add("RootSpaceStream", RootSpaceStream.ToResoniteReference(context));
members.Add("Position", Position.ToResoniteReference(context));
members.Add("Rotation", Rotation.ToResoniteReference(context));
members.Add("Scale", Scale.ToResoniteReference(context));
members.Add("AllowOffsets", AllowOffsets.ToResoniteLinkField());
members.Add("ResetStreamsOnDestroy", ResetStreamsOnDestroy.ToResoniteLinkField());
members.Add("PositionOffset", PositionOffset.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("ScaleOffset", ScaleOffset.ToResoniteLinkField());
members.Add("RunBeforePhysics", RunBeforePhysics.ToResoniteLinkField());
}

}
}
