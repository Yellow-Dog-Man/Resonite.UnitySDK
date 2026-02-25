
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SettingManagersManager
// Generated on: středa 25. února 2026 16:14:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SettingManagersManager")]
public partial class SettingManagersManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.SettingManager LocalSettings;
public global::FrooxEngine.SettingManager CloudSettings;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocalSettings", LocalSettings.ToResoniteReference(context));
members.Add("CloudSettings", CloudSettings.ToResoniteReference(context));
}

}
}
