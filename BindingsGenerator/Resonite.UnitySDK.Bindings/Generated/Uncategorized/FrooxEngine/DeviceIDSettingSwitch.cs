
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DeviceIDSettingSwitch
// Generated on: pondělí 2. března 2026 17:53:33
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DeviceIDSettingSwitch")]
public partial class DeviceIDSettingSwitch : global::FrooxEngine.SettingSwitch<global::FrooxEngine.DeviceIDSettingSwitchSource>

{
    public global::System.String DeviceID { get => DeviceID_Element.Data; set => DeviceID_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> DeviceID_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DeviceID", DeviceID_Element.ToLinkField(context));
}

}
}
