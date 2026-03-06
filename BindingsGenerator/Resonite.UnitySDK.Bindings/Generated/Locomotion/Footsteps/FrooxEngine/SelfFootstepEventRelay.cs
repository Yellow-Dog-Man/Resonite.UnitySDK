
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SelfFootstepEventRelay
// Generated on: pátek 6. března 2026 14:18:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SelfFootstepEventRelay")]
public partial class SelfFootstepEventRelay : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IFootstepEventReceiver, global::FrooxEngine.IFootstepEventRelay

{
    public global::FrooxEngine.Slot Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
}

}
}
