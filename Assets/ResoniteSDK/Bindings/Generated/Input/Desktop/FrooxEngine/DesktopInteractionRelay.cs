
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopInteractionRelay
// Generated on: pátek 13. února 2026 23:21:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopInteractionRelay")]
public partial class DesktopInteractionRelay : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIInteractable, global::FrooxEngine.IFocusable

{
    public global::System.Int32 DisplayIndex;
public global::System.Boolean UseLegacyTextInput;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DisplayIndex", DisplayIndex.ToResoniteLinkField());
members.Add("UseLegacyTextInput", UseLegacyTextInput.ToResoniteLinkField());
}

}
}
