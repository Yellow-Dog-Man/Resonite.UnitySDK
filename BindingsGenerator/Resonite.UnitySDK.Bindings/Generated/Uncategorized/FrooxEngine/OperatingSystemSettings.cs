
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OperatingSystemSettings
// Generated on: středa 25. února 2026 16:14:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OperatingSystemSettings")]
public partial class OperatingSystemSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.OperatingSystemSettings>

{
    public global::System.Boolean KeepOriginalScreenshotFormat;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("KeepOriginalScreenshotFormat", KeepOriginalScreenshotFormat.ToResoniteLinkField());
}

}
}
