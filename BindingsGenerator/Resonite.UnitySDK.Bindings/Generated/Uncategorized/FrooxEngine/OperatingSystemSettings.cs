
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OperatingSystemSettings
// Generated on: čtvrtek 26. února 2026 12:28:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.OperatingSystemSettings")]
public partial class OperatingSystemSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.OperatingSystemSettings>

{
    public global::System.Boolean KeepOriginalScreenshotFormat { get => KeepOriginalScreenshotFormat_Element.Data; set => KeepOriginalScreenshotFormat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> KeepOriginalScreenshotFormat_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("KeepOriginalScreenshotFormat", KeepOriginalScreenshotFormat_Element.ToLinkField(context));
}

}
}
