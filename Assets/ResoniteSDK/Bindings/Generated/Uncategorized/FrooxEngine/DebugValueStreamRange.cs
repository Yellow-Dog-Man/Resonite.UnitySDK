
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugValueStreamRange
// Generated on: sobota 14. února 2026 8:58:42
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
