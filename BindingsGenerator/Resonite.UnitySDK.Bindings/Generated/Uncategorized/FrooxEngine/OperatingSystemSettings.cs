
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.OperatingSystemSettings
// Generated on: pátek 6. března 2026 14:19:10
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
