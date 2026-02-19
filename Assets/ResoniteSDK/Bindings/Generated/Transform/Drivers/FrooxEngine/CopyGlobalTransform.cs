
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CopyGlobalTransform
// Generated on: čtvrtek 19. února 2026 8:00:23
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CopyGlobalTransform")]
public partial class CopyGlobalTransform : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot Source;
public global::FrooxEngine.IField<UnityEngine.Vector3> _posDrive;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("_posDrive", _posDrive.ToResoniteReference(context));
members.Add("_rotDrive", _rotDrive.ToResoniteReference(context));
}

}
}
