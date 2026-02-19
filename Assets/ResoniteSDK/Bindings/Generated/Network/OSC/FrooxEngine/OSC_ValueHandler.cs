
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_ValueHandler
// Generated on: čtvrtek 19. února 2026 7:59:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OSC_ValueHandler")]
public abstract partial class OSC_ValueHandler : global::FrooxEngine.Component

{
    public global::FrooxEngine.OSC_Handler Handler;
public global::System.String Path;
public global::System.Int32 ArgumentIndex;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Handler", Handler.ToResoniteReference(context));
members.Add("Path", Path.ToResoniteLinkField());
members.Add("ArgumentIndex", ArgumentIndex.ToResoniteLinkField());
}

}
}
