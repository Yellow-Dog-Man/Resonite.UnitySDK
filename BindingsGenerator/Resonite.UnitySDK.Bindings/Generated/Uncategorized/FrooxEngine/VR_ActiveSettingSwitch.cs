
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VR_ActiveSettingSwitch
// Generated on: čtvrtek 26. února 2026 15:09:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VR_ActiveSettingSwitch")]
public partial class VR_ActiveSettingSwitch : global::FrooxEngine.SettingSwitch<global::FrooxEngine.VR_ActiveSetttingSwitchSource>

{
    public global::System.Boolean VR_Active { get => VR_Active_Element.Data; set => VR_Active_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> VR_Active_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VR_Active", VR_Active_Element.ToLinkField(context));
}

}
}
