
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PointAnchor
// Generated on: středa 25. února 2026 16:14:19
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PointAnchor")]
public partial class PointAnchor : global::FrooxEngine.Component, global::FrooxEngine.IPointSnappable

{
    public global::FrooxEngine.Slot OwnerRoot;
public global::FrooxEngine.Slot SnapParent;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OwnerRoot", OwnerRoot.ToResoniteReference(context));
members.Add("SnapParent", SnapParent.ToResoniteReference(context));
}

}
}
