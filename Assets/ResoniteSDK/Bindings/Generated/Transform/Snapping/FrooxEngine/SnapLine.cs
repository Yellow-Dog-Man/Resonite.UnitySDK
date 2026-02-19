
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapLine
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SnapLine")]
public partial class SnapLine : global::FrooxEngine.Component, global::FrooxEngine.IPointSnappable

{
    public UnityEngine.Vector3 Point0;
public UnityEngine.Vector3 Point1;
public global::FrooxEngine.Slot Anchor0;
public global::FrooxEngine.Slot Anchor1;
public global::FrooxEngine.Slot SnapParent;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point0", Point0.ToResoniteLinkField());
members.Add("Point1", Point1.ToResoniteLinkField());
members.Add("Anchor0", Anchor0.ToResoniteReference(context));
members.Add("Anchor1", Anchor1.ToResoniteReference(context));
members.Add("SnapParent", SnapParent.ToResoniteReference(context));
}

}
}
