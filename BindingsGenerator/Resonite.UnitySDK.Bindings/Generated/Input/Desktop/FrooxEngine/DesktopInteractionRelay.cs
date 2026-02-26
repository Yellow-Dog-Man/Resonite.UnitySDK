
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopInteractionRelay
// Generated on: čtvrtek 26. února 2026 15:07:59
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopInteractionRelay")]
public partial class DesktopInteractionRelay : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIInteractable, global::FrooxEngine.IFocusable

{
    public global::System.Int32 DisplayIndex { get => DisplayIndex_Element.Data; set => DisplayIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> DisplayIndex_Element = new();
public global::System.Boolean UseLegacyTextInput { get => UseLegacyTextInput_Element.Data; set => UseLegacyTextInput_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseLegacyTextInput_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DisplayIndex", DisplayIndex_Element.ToLinkField(context));
members.Add("UseLegacyTextInput", UseLegacyTextInput_Element.ToLinkField(context));
}

}
}
