
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraAnchorSettings
// Generated on: sobota 14. února 2026 8:58:44
// Resonite version: 2026.2.14.493
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
