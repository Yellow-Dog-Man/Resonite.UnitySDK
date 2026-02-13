
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OperatingSystemSettings
// Generated on: pátek 13. února 2026 5:52:35
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OperatingSystemSettings")]
public partial class OperatingSystemSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.OperatingSystemSettings>

{
    public global::System.Boolean KeepOriginalScreenshotFormat;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("KeepOriginalScreenshotFormat", KeepOriginalScreenshotFormat.ToResoniteLinkField());
}

}
}
