
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TurnSubmodule
// Generated on: středa 25. února 2026 16:13:10
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
