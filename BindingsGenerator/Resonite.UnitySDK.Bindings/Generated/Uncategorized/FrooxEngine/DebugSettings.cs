
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugSettings
// Generated on: čtvrtek 26. února 2026 10:04:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugSettings")]
public partial class DebugSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.DebugSettings>

{
    public global::System.Boolean DebugInputBindings { get => DebugInputBindings_Element.Data; set => DebugInputBindings_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DebugInputBindings_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DebugInputBindings", DebugInputBindings_Element.Data.ToResoniteLinkField());
}

}
}
