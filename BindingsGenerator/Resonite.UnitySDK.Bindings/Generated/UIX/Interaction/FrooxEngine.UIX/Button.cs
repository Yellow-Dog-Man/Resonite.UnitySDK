
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.Button
// Generated on: čtvrtek 26. února 2026 12:26:52
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.VibratePreset HoverVibrate { get => HoverVibrate_Element.Data; set => HoverVibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> HoverVibrate_Element = new();
public global::FrooxEngine.VibratePreset PressVibrate { get => PressVibrate_Element.Data; set => PressVibrate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VibratePreset>, global::FrooxEngine.VibratePreset> PressVibrate_Element = new();
public global::System.Boolean ClearFocusOnPress { get => ClearFocusOnPress_Element.Data; set => ClearFocusOnPress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ClearFocusOnPress_Element = new();
public global::System.Boolean PassThroughHorizontalMovement { get => PassThroughHorizontalMovement_Element.Data; set => PassThroughHorizontalMovement_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PassThroughHorizontalMovement_Element = new();
public global::System.Boolean PassThroughVerticalMovement { get => PassThroughVerticalMovement_Element.Data; set => PassThroughVerticalMovement_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PassThroughVerticalMovement_Element = new();
public global::System.Boolean RequireLockInToPress { get => RequireLockInToPress_Element.Data; set => RequireLockInToPress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RequireLockInToPress_Element = new();
public global::System.Boolean RequireInitialPress { get => RequireInitialPress_Element.Data; set => RequireInitialPress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RequireInitialPress_Element = new();
public UnityEngine.Vector2 PressPoint { get => PressPoint_Element.Data; set => PressPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> PressPoint_Element = new();
public global::System.Boolean SendSlotEvents { get => SendSlotEvents_Element.Data; set => SendSlotEvents_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SendSlotEvents_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HoverVibrate", HoverVibrate_Element.ToLinkField(context));
members.Add("PressVibrate", PressVibrate_Element.ToLinkField(context));
members.Add("ClearFocusOnPress", ClearFocusOnPress_Element.ToLinkField(context));
members.Add("PassThroughHorizontalMovement", PassThroughHorizontalMovement_Element.ToLinkField(context));
members.Add("PassThroughVerticalMovement", PassThroughVerticalMovement_Element.ToLinkField(context));
members.Add("RequireLockInToPress", RequireLockInToPress_Element.ToLinkField(context));
members.Add("RequireInitialPress", RequireInitialPress_Element.ToLinkField(context));
members.Add("PressPoint", PressPoint_Element.ToLinkField(context));
members.Add("SendSlotEvents", SendSlotEvents_Element.ToLinkField(context));
}

}
}
