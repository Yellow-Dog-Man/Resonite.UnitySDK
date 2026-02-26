
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OrbCartridgeTool
// Generated on: čtvrtek 26. února 2026 15:09:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OrbCartridgeTool")]
public abstract partial class OrbCartridgeTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.Slot _orbSlot { get => _orbSlot_Element.Data; set => _orbSlot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _orbSlot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_orbSlot", _orbSlot_Element.ToLinkReference(context));
}

}
}
