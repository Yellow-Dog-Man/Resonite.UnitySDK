
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SettingManagersManager
// Generated on: čtvrtek 19. února 2026 8:00:30
// Resonite version: 2026.2.19.471
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
