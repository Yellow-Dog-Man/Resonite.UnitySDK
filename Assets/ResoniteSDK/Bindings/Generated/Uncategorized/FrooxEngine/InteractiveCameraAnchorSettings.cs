
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraAnchorSettings
// Generated on: čtvrtek 19. února 2026 8:00:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraAnchorSettings")]
public partial class InteractiveCameraAnchorSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraAnchorSettings>

{
    public global::System.Boolean InterpolateBetweenAnchors;
public global::System.Single AnchorInterpolationSpeed;
public global::System.Boolean UseLinearInterpolation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InterpolateBetweenAnchors", InterpolateBetweenAnchors.ToResoniteLinkField());
members.Add("AnchorInterpolationSpeed", AnchorInterpolationSpeed.ToResoniteLinkField());
members.Add("UseLinearInterpolation", UseLinearInterpolation.ToResoniteLinkField());
}

}
}
