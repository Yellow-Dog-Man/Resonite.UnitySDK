
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugLinePoint
// Generated on: pátek 13. února 2026 5:51:12
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugLinePoint")]
public partial class DebugLinePoint : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 LinePoint0;
public UnityEngine.Vector3 LinePoint1;
public System.Collections.Generic.List<UnityEngine.Vector3> Points;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LinePoint0", LinePoint0.ToResoniteLinkField());
members.Add("LinePoint1", LinePoint1.ToResoniteLinkField());
members.Add("Points", new ResoniteLink.SyncList()
{
    Elements = Points.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
}

}
}
