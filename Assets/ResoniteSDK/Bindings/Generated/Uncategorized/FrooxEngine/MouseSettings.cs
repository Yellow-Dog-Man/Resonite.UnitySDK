
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MouseSettings
// Generated on: pátek 13. února 2026 23:23:16
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MouseSettings")]
public partial class MouseSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.MouseSettings>

{
    public global::System.Single MouseSensitivity;
public global::System.Single ScrollWheelGrabMoveSpeed;
public global::System.Single MouseLookSpeed;
public global::System.Single MousePanSpeed;
public global::System.Single MouseRotateSpeed;
public global::System.Single MouseFreeformRotateSpeed;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MouseSensitivity", MouseSensitivity.ToResoniteLinkField());
members.Add("ScrollWheelGrabMoveSpeed", ScrollWheelGrabMoveSpeed.ToResoniteLinkField());
members.Add("MouseLookSpeed", MouseLookSpeed.ToResoniteLinkField());
members.Add("MousePanSpeed", MousePanSpeed.ToResoniteLinkField());
members.Add("MouseRotateSpeed", MouseRotateSpeed.ToResoniteLinkField());
members.Add("MouseFreeformRotateSpeed", MouseFreeformRotateSpeed.ToResoniteLinkField());
}

}
}
