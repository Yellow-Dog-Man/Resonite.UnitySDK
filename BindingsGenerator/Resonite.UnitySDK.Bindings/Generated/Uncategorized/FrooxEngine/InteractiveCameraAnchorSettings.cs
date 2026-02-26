
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraAnchorSettings
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraAnchorSettings")]
public partial class InteractiveCameraAnchorSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraAnchorSettings>

{
    public global::System.Boolean InterpolateBetweenAnchors { get => InterpolateBetweenAnchors_Element.Data; set => InterpolateBetweenAnchors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> InterpolateBetweenAnchors_Element = new();
public global::System.Single AnchorInterpolationSpeed { get => AnchorInterpolationSpeed_Element.Data; set => AnchorInterpolationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnchorInterpolationSpeed_Element = new();
public global::System.Boolean UseLinearInterpolation { get => UseLinearInterpolation_Element.Data; set => UseLinearInterpolation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseLinearInterpolation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InterpolateBetweenAnchors", InterpolateBetweenAnchors_Element.ToLinkField(context));
members.Add("AnchorInterpolationSpeed", AnchorInterpolationSpeed_Element.ToLinkField(context));
members.Add("UseLinearInterpolation", UseLinearInterpolation_Element.ToLinkField(context));
}

}
}
