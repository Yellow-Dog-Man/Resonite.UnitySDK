
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_ValueHandler
// Generated on: sobota 14. února 2026 8:57:08
// Resonite version: 2026.2.14.493
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
