
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraAnchor
// Generated on: čtvrtek 19. února 2026 7:59:00
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraAnchor")]
public partial class InteractiveCameraAnchor : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.Slot OverrideRoot;
public global::System.Single FieldOfView;
public global::System.Boolean Highlighted;
public global::System.Boolean InUse;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OverrideRoot", OverrideRoot.ToResoniteReference(context));
members.Add("FieldOfView", FieldOfView.ToResoniteLinkField());
members.Add("Highlighted", Highlighted.ToResoniteLinkField());
members.Add("InUse", InUse.ToResoniteLinkField());
}

}
}
