
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SettingManagersManager
// Generated on: čtvrtek 26. února 2026 15:09:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SettingManagersManager")]
public partial class SettingManagersManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.SettingManager LocalSettings { get => LocalSettings_Element.Data; set => LocalSettings_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SettingManager>, global::FrooxEngine.SettingManager> LocalSettings_Element = new();
public global::FrooxEngine.SettingManager CloudSettings { get => CloudSettings_Element.Data; set => CloudSettings_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SettingManager>, global::FrooxEngine.SettingManager> CloudSettings_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocalSettings", LocalSettings_Element.ToLinkReference(context));
members.Add("CloudSettings", CloudSettings_Element.ToLinkReference(context));
}

}
}
