
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapPlane
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SnapPlane")]
public partial class SnapPlane : global::FrooxEngine.Component, global::FrooxEngine.IPointSnappable, global::FrooxEngine.IUIInterface

{
    public UnityEngine.Vector3 Normal;
public global::FrooxEngine.Slot SnapParent;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Normal", Normal.ToResoniteLinkField());
members.Add("SnapParent", SnapParent.ToResoniteReference(context));
}

}
}
