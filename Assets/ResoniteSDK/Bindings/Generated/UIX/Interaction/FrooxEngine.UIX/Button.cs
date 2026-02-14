
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Button
// Generated on: sobota 14. února 2026 8:57:02
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.Button")]
public partial class Button : global::FrooxEngine.UIX.InteractionElement, global::FrooxEngine.IButton

{
    public global::FrooxEngine.VibratePreset HoverVibrate;
public global::FrooxEngine.VibratePreset PressVibrate;
public global::System.Boolean ClearFocusOnPress;
public global::System.Boolean PassThroughHorizontalMovement;
public global::System.Boolean PassThroughVerticalMovement;
public global::System.Boolean RequireLockInToPress;
public global::System.Boolean RequireInitialPress;
public UnityEngine.Vector2 PressPoint;
public global::System.Boolean SendSlotEvents;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HoverVibrate", HoverVibrate.ToResoniteLinkField());
members.Add("PressVibrate", PressVibrate.ToResoniteLinkField());
members.Add("ClearFocusOnPress", ClearFocusOnPress.ToResoniteLinkField());
members.Add("PassThroughHorizontalMovement", PassThroughHorizontalMovement.ToResoniteLinkField());
members.Add("PassThroughVerticalMovement", PassThroughVerticalMovement.ToResoniteLinkField());
members.Add("RequireLockInToPress", RequireLockInToPress.ToResoniteLinkField());
members.Add("RequireInitialPress", RequireInitialPress.ToResoniteLinkField());
members.Add("PressPoint", PressPoint.ToResoniteLinkField());
members.Add("SendSlotEvents", SendSlotEvents.ToResoniteLinkField());
}

}
}
