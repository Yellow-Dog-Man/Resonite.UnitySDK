
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraPostProcessingSettings
// Generated on: čtvrtek 26. února 2026 15:09:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraPostProcessingSettings")]
public partial class InteractiveCameraPostProcessingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraPostProcessingSettings>

{
    public global::System.Boolean MotionBlur { get => MotionBlur_Element.Data; set => MotionBlur_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MotionBlur_Element = new();
public global::System.Boolean ScreenSpaceReflections { get => ScreenSpaceReflections_Element.Data; set => ScreenSpaceReflections_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScreenSpaceReflections_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MotionBlur", MotionBlur_Element.ToLinkField(context));
members.Add("ScreenSpaceReflections", ScreenSpaceReflections_Element.ToLinkField(context));
}

}
}
