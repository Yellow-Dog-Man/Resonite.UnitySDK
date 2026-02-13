
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TransformStreamDriver
// Generated on: pátek 13. února 2026 23:23:19
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PositionStream", new ResoniteLink.Reference() { });
members.Add("RotationStream", new ResoniteLink.Reference() { });
members.Add("ScaleStream", new ResoniteLink.Reference() { });
members.Add("RootSpaceStream", new ResoniteLink.Reference() { });
members.Add("Position", new ResoniteLink.Reference() { });
members.Add("Rotation", new ResoniteLink.Reference() { });
members.Add("Scale", new ResoniteLink.Reference() { });
members.Add("AllowOffsets", AllowOffsets.ToResoniteLinkField());
members.Add("ResetStreamsOnDestroy", ResetStreamsOnDestroy.ToResoniteLinkField());
members.Add("PositionOffset", PositionOffset.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("ScaleOffset", ScaleOffset.ToResoniteLinkField());
members.Add("RunBeforePhysics", RunBeforePhysics.ToResoniteLinkField());
}

}
}
