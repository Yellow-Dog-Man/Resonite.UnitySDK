
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TurnSubmodule
// Generated on: pátek 13. února 2026 23:21:41
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ThreeAxisRotation", ThreeAxisRotation.ToResoniteLinkField());
members.Add("_controller", new ResoniteLink.Reference() { });
}

}
}
