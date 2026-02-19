
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TOTP_Dialog
// Generated on: čtvrtek 19. února 2026 8:00:31
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.UIX.SlideSwapRegion _swapRegion;
public global::FrooxEngine.TOTP_Dialog.State _state;
public global::FrooxEngine.UIX.TextField _codeField;
public global::FrooxEngine.UIX.Text _messageText;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_swapRegion", _swapRegion.ToResoniteReference(context));
members.Add("_state", _state.ToResoniteLinkField());
members.Add("_codeField", _codeField.ToResoniteReference(context));
members.Add("_messageText", _messageText.ToResoniteReference(context));
}

}
}
