
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TurnSubmodule
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TurnSubmodule")]
public partial class TurnSubmodule : global::FrooxEngine.SyncObject

{
    public global::System.Boolean ThreeAxisRotation;
public global::FrooxEngine.LocomotionController _controller;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ThreeAxisRotation", ThreeAxisRotation.ToResoniteLinkField());
members.Add("_controller", _controller.ToResoniteReference(context));
}

}
}
