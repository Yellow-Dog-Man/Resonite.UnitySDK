
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GeneralHapticsSettings
// Generated on: pondělí 2. března 2026 17:53:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GeneralHapticsSettings")]
public partial class GeneralHapticsSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.GeneralHapticsSettings>

{
    public global::System.Boolean EnableControllerVibration { get => EnableControllerVibration_Element.Data; set => EnableControllerVibration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EnableControllerVibration_Element = new();
public global::System.Boolean EnableHaptics { get => EnableHaptics_Element.Data; set => EnableHaptics_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EnableHaptics_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EnableControllerVibration", EnableControllerVibration_Element.ToLinkField(context));
members.Add("EnableHaptics", EnableHaptics_Element.ToLinkField(context));
}

}
}
