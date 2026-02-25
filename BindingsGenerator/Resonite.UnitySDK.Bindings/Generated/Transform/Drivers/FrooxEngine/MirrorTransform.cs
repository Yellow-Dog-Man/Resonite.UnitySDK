
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MirrorTransform
// Generated on: středa 25. února 2026 16:14:30
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MirrorTransform")]
public partial class MirrorTransform : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot MirrorSource;
public global::FrooxEngine.Slot MirrorPlane;
public UnityEngine.Vector3 MirrorOffset;
public UnityEngine.Vector3 MirrorNormal;
public global::System.Boolean AllowWriteBack;
public global::FrooxEngine.IField<UnityEngine.Vector3> _position;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MirrorSource", MirrorSource.ToResoniteReference(context));
members.Add("MirrorPlane", MirrorPlane.ToResoniteReference(context));
members.Add("MirrorOffset", MirrorOffset.ToResoniteLinkField());
members.Add("MirrorNormal", MirrorNormal.ToResoniteLinkField());
members.Add("AllowWriteBack", AllowWriteBack.ToResoniteLinkField());
members.Add("_position", _position.ToResoniteReference(context));
members.Add("_rotation", _rotation.ToResoniteReference(context));
}

}
}
