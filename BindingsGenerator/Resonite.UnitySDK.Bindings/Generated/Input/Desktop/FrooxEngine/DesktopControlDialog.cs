
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopControlDialog
// Generated on: pátek 14. srpna 2026 21:54:15
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
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
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.DesktopInteractionRelay>, global::FrooxEngine.DesktopInteractionRelay> InteractionRelay_Element = new();
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
public global::Elements.Core.Corner ButtonCorner { get => ButtonCorner_Element.Data; set => ButtonCorner_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.Corner>, global::Elements.Core.Corner> ButtonCorner_Element = new();
public global::FrooxEngine.UIX.Button _streamButton { get => _streamButton_Element.Data; set => _streamButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _streamButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InteractionRelay", InteractionRelay_Element.ToLinkReference(context));
members.Add("Index", Index_Element.ToLinkField(context));
members.Add("FollowCursor", FollowCursor_Element.ToLinkField(context));
members.Add("Brightness", Brightness_Element.ToLinkField(context));
members.Add("Opacity", Opacity_Element.ToLinkField(context));
members.Add("LegacyInputMode", LegacyInputMode_Element.ToLinkField(context));
members.Add("ButtonCorner", ButtonCorner_Element.ToLinkField(context));
members.Add("_streamButton", _streamButton_Element.ToLinkReference(context));
}

}
}
