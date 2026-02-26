
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Perspective360Panner
// Generated on: čtvrtek 26. února 2026 15:07:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Perspective360Panner")]
public partial class Perspective360Panner : global::FrooxEngine.Component, global::FrooxEngine.IButtonHoverReceiver

{
    public global::System.Single IdleFOV { get => IdleFOV_Element.Data; set => IdleFOV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> IdleFOV_Element = new();
public global::System.Single HoverFOV { get => HoverFOV_Element.Data; set => HoverFOV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HoverFOV_Element = new();
public global::System.Single FOVSpeed { get => FOVSpeed_Element.Data; set => FOVSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FOVSpeed_Element = new();
public global::System.Single HorizontalPanningAcceleration { get => HorizontalPanningAcceleration_Element.Data; set => HorizontalPanningAcceleration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HorizontalPanningAcceleration_Element = new();
public global::System.Single HorizontalPanningSpeed { get => HorizontalPanningSpeed_Element.Data; set => HorizontalPanningSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HorizontalPanningSpeed_Element = new();
public global::System.Single VerticalPanningSpeed { get => VerticalPanningSpeed_Element.Data; set => VerticalPanningSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VerticalPanningSpeed_Element = new();
public global::System.Single VerticalRange { get => VerticalRange_Element.Data; set => VerticalRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VerticalRange_Element = new();
public UnityEngine.Vector2 AngleOffset { get => AngleOffset_Element.Data; set => AngleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> AngleOffset_Element = new();
public UnityEngine.Vector2 FOV { get => FOV_Element.Data; set => FOV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> FOV_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IdleFOV", IdleFOV_Element.ToLinkField(context));
members.Add("HoverFOV", HoverFOV_Element.ToLinkField(context));
members.Add("FOVSpeed", FOVSpeed_Element.ToLinkField(context));
members.Add("HorizontalPanningAcceleration", HorizontalPanningAcceleration_Element.ToLinkField(context));
members.Add("HorizontalPanningSpeed", HorizontalPanningSpeed_Element.ToLinkField(context));
members.Add("VerticalPanningSpeed", VerticalPanningSpeed_Element.ToLinkField(context));
members.Add("VerticalRange", VerticalRange_Element.ToLinkField(context));
members.Add("AngleOffset", AngleOffset_Element.ToLinkField(context));
members.Add("FOV", FOV_Element.ToLinkField(context));
}

}
}
