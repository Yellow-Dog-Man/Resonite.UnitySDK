
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugValueStreamRange
// Generated on: čtvrtek 19. února 2026 8:00:26
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugValueStreamRange")]
public partial class DebugValueStreamRange : global::FrooxEngine.Component

{
    public global::FrooxEngine.ValueStream<UnityEngine.Vector3> Stream;
public global::FrooxEngine.IField<UnityEngine.Vector3> positionDrive;
public global::FrooxEngine.IField<UnityEngine.Vector3> sizeDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stream", Stream.ToResoniteReference(context));
members.Add("positionDrive", positionDrive.ToResoniteReference(context));
members.Add("sizeDrive", sizeDrive.ToResoniteReference(context));
}

}
}
