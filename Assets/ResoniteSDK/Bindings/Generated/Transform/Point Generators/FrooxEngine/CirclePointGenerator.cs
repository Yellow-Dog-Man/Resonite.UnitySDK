
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CirclePointGenerator
// Generated on: pátek 13. února 2026 5:52:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CirclePointGenerator")]
public partial class CirclePointGenerator : global::FrooxEngine.Component, global::FrooxEngine.IPointGenerator

{
    public global::System.Single Radius;
public global::System.Boolean Shell;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Shell", Shell.ToResoniteLinkField());
}

}
}
