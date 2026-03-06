
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationBodyCollider
// Generated on: pátek 6. března 2026 14:19:12
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationBodyCollider")]
public partial class LocomotionAnimationBodyCollider : global::FrooxEngine.Component

{
    public global::System.Boolean IgnoreForLeftHand { get => IgnoreForLeftHand_Element.Data; set => IgnoreForLeftHand_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreForLeftHand_Element = new();
public global::System.Boolean IgnoreForRightHand { get => IgnoreForRightHand_Element.Data; set => IgnoreForRightHand_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreForRightHand_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IgnoreForLeftHand", IgnoreForLeftHand_Element.ToLinkField(context));
members.Add("IgnoreForRightHand", IgnoreForRightHand_Element.ToLinkField(context));
}

}
}
