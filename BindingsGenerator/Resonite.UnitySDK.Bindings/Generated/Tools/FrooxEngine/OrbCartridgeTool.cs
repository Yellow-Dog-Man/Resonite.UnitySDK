
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OrbCartridgeTool
// Generated on: pondělí 2. března 2026 17:53:30
// Resonite version: 2026.3.2.1000
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
