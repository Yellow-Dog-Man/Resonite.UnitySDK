
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MouseSettings
// Generated on: čtvrtek 26. února 2026 15:09:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MouseSettings")]
public partial class MouseSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.MouseSettings>

{
    public global::System.Single MouseSensitivity { get => MouseSensitivity_Element.Data; set => MouseSensitivity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MouseSensitivity_Element = new();
public global::System.Single ScrollWheelGrabMoveSpeed { get => ScrollWheelGrabMoveSpeed_Element.Data; set => ScrollWheelGrabMoveSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ScrollWheelGrabMoveSpeed_Element = new();
public global::System.Single MouseLookSpeed { get => MouseLookSpeed_Element.Data; set => MouseLookSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MouseLookSpeed_Element = new();
public global::System.Single MousePanSpeed { get => MousePanSpeed_Element.Data; set => MousePanSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MousePanSpeed_Element = new();
public global::System.Single MouseRotateSpeed { get => MouseRotateSpeed_Element.Data; set => MouseRotateSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MouseRotateSpeed_Element = new();
public global::System.Single MouseFreeformRotateSpeed { get => MouseFreeformRotateSpeed_Element.Data; set => MouseFreeformRotateSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MouseFreeformRotateSpeed_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MouseSensitivity", MouseSensitivity_Element.ToLinkField(context));
members.Add("ScrollWheelGrabMoveSpeed", ScrollWheelGrabMoveSpeed_Element.ToLinkField(context));
members.Add("MouseLookSpeed", MouseLookSpeed_Element.ToLinkField(context));
members.Add("MousePanSpeed", MousePanSpeed_Element.ToLinkField(context));
members.Add("MouseRotateSpeed", MouseRotateSpeed_Element.ToLinkField(context));
members.Add("MouseFreeformRotateSpeed", MouseFreeformRotateSpeed_Element.ToLinkField(context));
}

}
}
