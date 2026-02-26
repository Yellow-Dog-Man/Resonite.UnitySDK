
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugSettingSwitch
// Generated on: čtvrtek 26. února 2026 12:28:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugSettingSwitch")]
public partial class DebugSettingSwitch : global::FrooxEngine.SettingSwitch<global::FrooxEngine.DebugSettingSwitchSource>

{
    public global::System.String TargetProfile { get => TargetProfile_Element.Data; set => TargetProfile_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> TargetProfile_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetProfile", TargetProfile_Element.ToLinkField(context));
}

}
}
