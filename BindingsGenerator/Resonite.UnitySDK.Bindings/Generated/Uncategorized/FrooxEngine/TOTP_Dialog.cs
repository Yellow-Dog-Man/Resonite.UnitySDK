
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TOTP_Dialog
// Generated on: čtvrtek 26. února 2026 10:04:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TOTP_Dialog")]
public partial class TOTP_Dialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.SlideSwapRegion _swapRegion { get => _swapRegion_Element.Data; set => _swapRegion_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.SlideSwapRegion>, global::FrooxEngine.UIX.SlideSwapRegion> _swapRegion_Element = new();
public global::FrooxEngine.TOTP_Dialog.State _state { get => _state_Element.Data; set => _state_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.TOTP_Dialog.State>, global::FrooxEngine.TOTP_Dialog.State> _state_Element = new();
public global::FrooxEngine.UIX.TextField _codeField { get => _codeField_Element.Data; set => _codeField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _codeField_Element = new();
public global::FrooxEngine.UIX.Text _messageText { get => _messageText_Element.Data; set => _messageText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _messageText_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_swapRegion", _swapRegion_Element.Data.ToResoniteReference(context));
members.Add("_state", _state_Element.Data.ToResoniteLinkField());
members.Add("_codeField", _codeField_Element.Data.ToResoniteReference(context));
members.Add("_messageText", _messageText_Element.Data.ToResoniteReference(context));
}

}
}
