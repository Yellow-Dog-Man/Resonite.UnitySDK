
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopControlDialog
// Generated on: čtvrtek 26. února 2026 10:03:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopControlDialog")]
public partial class DesktopControlDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.DesktopInteractionRelay InteractionRelay { get => InteractionRelay_Element.Data; set => InteractionRelay_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.DesktopInteractionRelay>, global::FrooxEngine.DesktopInteractionRelay> InteractionRelay_Element = new();
public global::System.Int32 Index { get => Index_Element.Data; set => Index_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Index_Element = new();
public global::System.Boolean FollowCursor { get => FollowCursor_Element.Data; set => FollowCursor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FollowCursor_Element = new();
public global::System.Single Brightness { get => Brightness_Element.Data; set => Brightness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Brightness_Element = new();
public global::System.Single Opacity { get => Opacity_Element.Data; set => Opacity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Opacity_Element = new();
public global::System.Boolean LegacyInputMode { get => LegacyInputMode_Element.Data; set => LegacyInputMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LegacyInputMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InteractionRelay", InteractionRelay_Element.Data.ToResoniteReference(context));
members.Add("Index", Index_Element.Data.ToResoniteLinkField());
members.Add("FollowCursor", FollowCursor_Element.Data.ToResoniteLinkField());
members.Add("Brightness", Brightness_Element.Data.ToResoniteLinkField());
members.Add("Opacity", Opacity_Element.Data.ToResoniteLinkField());
members.Add("LegacyInputMode", LegacyInputMode_Element.Data.ToResoniteLinkField());
}

}
}
