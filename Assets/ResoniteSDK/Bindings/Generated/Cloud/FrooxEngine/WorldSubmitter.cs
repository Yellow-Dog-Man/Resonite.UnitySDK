
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldSubmitter
// Generated on: čtvrtek 19. února 2026 7:58:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldSubmitter")]
public partial class WorldSubmitter : global::FrooxEngine.Component

{
    public global::System.String GroupId;
public global::System.Single Radius;
public global::System.Single Height;
public global::FrooxEngine.Slot _visual;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GroupId", GroupId.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("_visual", _visual.ToResoniteReference(context));
}

}
}
