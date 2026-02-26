
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopController
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopController")]
public partial class DesktopController : global::FrooxEngine.Component

{
    public global::System.Boolean FollowCursor { get => FollowCursor_Element.Data; set => FollowCursor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FollowCursor_Element = new();
public global::System.Boolean LegacyInputMode { get => LegacyInputMode_Element.Data; set => LegacyInputMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LegacyInputMode_Element = new();
public global::System.Single Brightness { get => Brightness_Element.Data; set => Brightness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Brightness_Element = new();
public global::System.Single Opacity { get => Opacity_Element.Data; set => Opacity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Opacity_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _displayColor { get => _displayColor_Element.Data; set => _displayColor_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _displayColor_Element = new();
public global::FrooxEngine.UIX.RectTransform _displayRect { get => _displayRect_Element.Data; set => _displayRect_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> _displayRect_Element = new();
public global::FrooxEngine.DesktopTextureProvider _desktopTexture { get => _desktopTexture_Element.Data; set => _desktopTexture_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.DesktopTextureProvider>, global::FrooxEngine.DesktopTextureProvider> _desktopTexture_Element = new();
public global::FrooxEngine.DesktopInteractionRelay _interactionRelay { get => _interactionRelay_Element.Data; set => _interactionRelay_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.DesktopInteractionRelay>, global::FrooxEngine.DesktopInteractionRelay> _interactionRelay_Element = new();
public global::FrooxEngine.DesktopControlDialog _currentControl { get => _currentControl_Element.Data; set => _currentControl_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.DesktopControlDialog>, global::FrooxEngine.DesktopControlDialog> _currentControl_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FollowCursor", FollowCursor_Element.Data.ToResoniteLinkField());
members.Add("LegacyInputMode", LegacyInputMode_Element.Data.ToResoniteLinkField());
members.Add("Brightness", Brightness_Element.Data.ToResoniteLinkField());
members.Add("Opacity", Opacity_Element.Data.ToResoniteLinkField());
members.Add("_displayColor", _displayColor_Element.Data.ToResoniteReference(context));
members.Add("_displayRect", _displayRect_Element.Data.ToResoniteReference(context));
members.Add("_desktopTexture", _desktopTexture_Element.Data.ToResoniteReference(context));
members.Add("_interactionRelay", _interactionRelay_Element.Data.ToResoniteReference(context));
members.Add("_currentControl", _currentControl_Element.Data.ToResoniteReference(context));
}

}
}
