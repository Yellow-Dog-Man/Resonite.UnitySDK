
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugSphereSectorDistance
// Generated on: pátek 13. února 2026 23:21:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugSphereSectorDistance")]
public partial class DebugSphereSectorDistance : global::FrooxEngine.Component

{
    public global::System.Single Angle;
public global::System.Single Radius;
public System.Collections.Generic.List<UnityEngine.Vector3> Points;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Angle", Angle.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Points", new ResoniteLink.SyncList()
{
    Elements = Points.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
