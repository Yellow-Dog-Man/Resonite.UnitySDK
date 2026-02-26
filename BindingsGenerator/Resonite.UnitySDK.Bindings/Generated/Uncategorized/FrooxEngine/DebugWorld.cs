
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugWorld
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugWorld")]
public partial class DebugWorld : global::FrooxEngine.Component

{
    public global::FrooxEngine.Sync<global::System.String> text { get => text_Element.Data; set => text_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.Sync<global::System.String>>, global::FrooxEngine.Sync<global::System.String>> text_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("text", text_Element.ToLinkReference(context));
}

}
}
