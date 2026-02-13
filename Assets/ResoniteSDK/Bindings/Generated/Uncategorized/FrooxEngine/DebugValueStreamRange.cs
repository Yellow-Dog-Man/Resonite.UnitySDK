
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugValueStreamRange
// Generated on: pátek 13. února 2026 23:23:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugValueStreamRange")]
public partial class DebugValueStreamRange : global::FrooxEngine.Component

{
    public global::FrooxEngine.ValueStream<UnityEngine.Vector3> Stream;
public global::FrooxEngine.IField<UnityEngine.Vector3> positionDrive;
public global::FrooxEngine.IField<UnityEngine.Vector3> sizeDrive;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Stream", new ResoniteLink.Reference() { });
members.Add("positionDrive", new ResoniteLink.Reference() { });
members.Add("sizeDrive", new ResoniteLink.Reference() { });
}

}
}
