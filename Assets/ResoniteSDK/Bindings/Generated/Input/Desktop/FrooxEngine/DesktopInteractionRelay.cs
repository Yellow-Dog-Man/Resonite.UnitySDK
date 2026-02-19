
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopInteractionRelay
// Generated on: čtvrtek 19. února 2026 7:58:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopInteractionRelay")]
public partial class DesktopInteractionRelay : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIInteractable, global::FrooxEngine.IFocusable

{
    public global::System.Int32 DisplayIndex;
public global::System.Boolean UseLegacyTextInput;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DisplayIndex", DisplayIndex.ToResoniteLinkField());
members.Add("UseLegacyTextInput", UseLegacyTextInput.ToResoniteLinkField());
}

}
}
