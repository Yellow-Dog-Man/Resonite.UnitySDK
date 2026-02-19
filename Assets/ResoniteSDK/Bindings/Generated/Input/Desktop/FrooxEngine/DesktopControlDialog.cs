
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopControlDialog
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopControlDialog")]
public partial class DesktopControlDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.DesktopInteractionRelay InteractionRelay;
public global::System.Int32 Index;
public global::System.Boolean FollowCursor;
public global::System.Single Brightness;
public global::System.Single Opacity;
public global::System.Boolean LegacyInputMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InteractionRelay", InteractionRelay.ToResoniteReference(context));
members.Add("Index", Index.ToResoniteLinkField());
members.Add("FollowCursor", FollowCursor.ToResoniteLinkField());
members.Add("Brightness", Brightness.ToResoniteLinkField());
members.Add("Opacity", Opacity.ToResoniteLinkField());
members.Add("LegacyInputMode", LegacyInputMode.ToResoniteLinkField());
}

}
}
