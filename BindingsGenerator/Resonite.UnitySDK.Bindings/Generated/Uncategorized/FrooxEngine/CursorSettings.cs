
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CursorSettings
// Generated on: středa 25. února 2026 16:14:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CursorSettings")]
public partial class CursorSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.CursorSettings>

{
    public global::System.Single BaseCursorSize;
public global::System.Single GrabMultiplier;
public global::System.Single InteractionMultiplier;
public global::System.Single TextMultiplier;
public global::System.Single SliderMultiplier;
public global::System.Boolean DirectCursorEnabled;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseCursorSize", BaseCursorSize.ToResoniteLinkField());
members.Add("GrabMultiplier", GrabMultiplier.ToResoniteLinkField());
members.Add("InteractionMultiplier", InteractionMultiplier.ToResoniteLinkField());
members.Add("TextMultiplier", TextMultiplier.ToResoniteLinkField());
members.Add("SliderMultiplier", SliderMultiplier.ToResoniteLinkField());
members.Add("DirectCursorEnabled", DirectCursorEnabled.ToResoniteLinkField());
}

}
}
