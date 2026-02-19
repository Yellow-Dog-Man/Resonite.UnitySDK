
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugVector
// Generated on: čtvrtek 19. února 2026 7:58:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugVector")]
public partial class DebugVector : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 PositionOffset;
public UnityEngine.Quaternion RotationOffset;
public UnityEngine.Vector3 Vector;
public UnityEngine.ColorX Color;
public global::System.Boolean UseGlobalSpace;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionOffset", PositionOffset.ToResoniteLinkField());
members.Add("RotationOffset", RotationOffset.ToResoniteLinkField());
members.Add("Vector", Vector.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("UseGlobalSpace", UseGlobalSpace.ToResoniteLinkField());
}

}
}
