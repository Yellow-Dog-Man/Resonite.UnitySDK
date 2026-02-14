
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SquarePointGenerator
// Generated on: sobota 14. února 2026 8:58:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SquarePointGenerator")]
public partial class SquarePointGenerator : global::FrooxEngine.Component, global::FrooxEngine.IPointGenerator

{
    public UnityEngine.Vector2 Size;
public global::System.Boolean Shell;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Shell", Shell.ToResoniteLinkField());
}

}
}
