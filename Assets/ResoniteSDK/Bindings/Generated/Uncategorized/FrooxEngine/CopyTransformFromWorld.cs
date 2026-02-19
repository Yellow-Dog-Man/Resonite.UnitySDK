
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CopyTransformFromWorld
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CopyTransformFromWorld")]
public partial class CopyTransformFromWorld : global::FrooxEngine.Component

{
    public global::System.Boolean CopyPosition;
public global::System.Boolean CopyRotation;
public global::System.Boolean CopyScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CopyPosition", CopyPosition.ToResoniteLinkField());
members.Add("CopyRotation", CopyRotation.ToResoniteLinkField());
members.Add("CopyScale", CopyScale.ToResoniteLinkField());
}

}
}
