
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TOTP_Dialog
// Generated on: pátek 13. února 2026 23:23:18
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TOTP_Dialog")]
public partial class TOTP_Dialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.SlideSwapRegion _swapRegion;
public global::FrooxEngine.TOTP_Dialog.State _state;
public global::FrooxEngine.UIX.TextField _codeField;
public global::FrooxEngine.UIX.Text _messageText;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_swapRegion", new ResoniteLink.Reference() { });
members.Add("_state", _state.ToResoniteLinkField());
members.Add("_codeField", new ResoniteLink.Reference() { });
members.Add("_messageText", new ResoniteLink.Reference() { });
}

}
}
