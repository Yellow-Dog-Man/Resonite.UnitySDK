
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OSC_ValueHandler
// Generated on: čtvrtek 26. února 2026 12:26:57
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OSC_ValueHandler")]
public abstract partial class OSC_ValueHandler : global::FrooxEngine.Component

{
    public global::FrooxEngine.OSC_Handler Handler { get => Handler_Element.Data; set => Handler_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.OSC_Handler>, global::FrooxEngine.OSC_Handler> Handler_Element = new();
public global::System.String Path { get => Path_Element.Data; set => Path_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Path_Element = new();
public global::System.Int32 ArgumentIndex { get => ArgumentIndex_Element.Data; set => ArgumentIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ArgumentIndex_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Handler", Handler_Element.ToLinkReference(context));
members.Add("Path", Path_Element.ToLinkField(context));
members.Add("ArgumentIndex", ArgumentIndex_Element.ToLinkField(context));
}

}
}
