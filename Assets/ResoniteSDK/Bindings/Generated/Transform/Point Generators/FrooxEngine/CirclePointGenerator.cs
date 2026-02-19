
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CirclePointGenerator
// Generated on: čtvrtek 19. února 2026 8:00:24
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CirclePointGenerator")]
public partial class CirclePointGenerator : global::FrooxEngine.Component, global::FrooxEngine.IPointGenerator

{
    public global::System.Single Radius;
public global::System.Boolean Shell;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Shell", Shell.ToResoniteLinkField());
}

}
}
