
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonEditColorX
// Generated on: pátek 13. února 2026 23:21:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonEditColorX")]
public partial class ButtonEditColorX : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.IField<UnityEngine.ColorX> Target;
public global::FrooxEngine.ColorDialogInterface _colorPicker;
public global::System.Boolean Continuous;
public global::System.Boolean Alpha;
public global::System.Boolean HDR;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("_colorPicker", new ResoniteLink.Reference() { });
members.Add("Continuous", Continuous.ToResoniteLinkField());
members.Add("Alpha", Alpha.ToResoniteLinkField());
members.Add("HDR", HDR.ToResoniteLinkField());
}

}
}
