
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugLinePoint
// Generated on: úterý 24. února 2026 18:17:48
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugLinePoint")]
public partial class DebugLinePoint : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 LinePoint0;
public UnityEngine.Vector3 LinePoint1;
public System.Collections.Generic.List<UnityEngine.Vector3> Points;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LinePoint0", LinePoint0.ToResoniteLinkField());
members.Add("LinePoint1", LinePoint1.ToResoniteLinkField());
members.Add("Points", new ResoniteLink.SyncList()
{
    Elements = Points.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
