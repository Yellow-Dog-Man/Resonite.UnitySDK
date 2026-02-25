
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraAnchorSettings
// Generated on: středa 25. února 2026 16:14:39
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
