
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Perspective360Panner
// Generated on: středa 25. února 2026 16:13:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Perspective360Panner")]
public partial class Perspective360Panner : global::FrooxEngine.Component, global::FrooxEngine.IButtonHoverReceiver

{
    public global::System.Single IdleFOV;
public global::System.Single HoverFOV;
public global::System.Single FOVSpeed;
public global::System.Single HorizontalPanningAcceleration;
public global::System.Single HorizontalPanningSpeed;
public global::System.Single VerticalPanningSpeed;
public global::System.Single VerticalRange;
public UnityEngine.Vector2 AngleOffset;
public UnityEngine.Vector2 FOV;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IdleFOV", IdleFOV.ToResoniteLinkField());
members.Add("HoverFOV", HoverFOV.ToResoniteLinkField());
members.Add("FOVSpeed", FOVSpeed.ToResoniteLinkField());
members.Add("HorizontalPanningAcceleration", HorizontalPanningAcceleration.ToResoniteLinkField());
members.Add("HorizontalPanningSpeed", HorizontalPanningSpeed.ToResoniteLinkField());
members.Add("VerticalPanningSpeed", VerticalPanningSpeed.ToResoniteLinkField());
members.Add("VerticalRange", VerticalRange.ToResoniteLinkField());
members.Add("AngleOffset", AngleOffset.ToResoniteLinkField());
members.Add("FOV", FOV.ToResoniteLinkField());
}

}
}
