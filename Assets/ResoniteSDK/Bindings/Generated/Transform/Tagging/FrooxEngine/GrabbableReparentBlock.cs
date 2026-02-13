
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabbableReparentBlock
// Generated on: pátek 13. února 2026 23:23:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabbableReparentBlock")]
public partial class GrabbableReparentBlock : global::FrooxEngine.Component, global::FrooxEngine.IGrabbableReparentBlock, global::FrooxEngine.IInteractionBlock

{
    public global::System.Boolean DontReparent;
public global::System.Int32 MaxDepth;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DontReparent", DontReparent.ToResoniteLinkField());
members.Add("MaxDepth", MaxDepth.ToResoniteLinkField());
}

}
}
