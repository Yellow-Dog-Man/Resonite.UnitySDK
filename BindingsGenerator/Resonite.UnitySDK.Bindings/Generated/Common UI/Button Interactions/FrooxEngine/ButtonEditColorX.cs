
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonEditColorX
// Generated on: středa 25. února 2026 16:13:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonEditColorX")]
public partial class ButtonEditColorX : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.IField<UnityEngine.ColorX> Target;
public global::FrooxEngine.ColorDialogInterface _colorPicker;
public global::System.Boolean Continuous;
public global::System.Boolean Alpha;
public global::System.Boolean HDR;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("_colorPicker", _colorPicker.ToResoniteReference(context));
members.Add("Continuous", Continuous.ToResoniteLinkField());
members.Add("Alpha", Alpha.ToResoniteLinkField());
members.Add("HDR", HDR.ToResoniteLinkField());
}

}
}
