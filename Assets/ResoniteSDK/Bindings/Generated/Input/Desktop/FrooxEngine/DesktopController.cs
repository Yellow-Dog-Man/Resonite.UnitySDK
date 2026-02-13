
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopController
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopController")]
public partial class DesktopController : global::FrooxEngine.Component

{
    public global::System.Boolean FollowCursor;
public global::System.Boolean LegacyInputMode;
public global::System.Single Brightness;
public global::System.Single Opacity;
public global::FrooxEngine.IField<UnityEngine.ColorX> _displayColor;
public global::FrooxEngine.UIX.RectTransform _displayRect;
public global::FrooxEngine.DesktopTextureProvider _desktopTexture;
public global::FrooxEngine.DesktopInteractionRelay _interactionRelay;
public global::FrooxEngine.DesktopControlDialog _currentControl;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("FollowCursor", FollowCursor.ToResoniteLinkField());
members.Add("LegacyInputMode", LegacyInputMode.ToResoniteLinkField());
members.Add("Brightness", Brightness.ToResoniteLinkField());
members.Add("Opacity", Opacity.ToResoniteLinkField());
members.Add("_displayColor", new ResoniteLink.Reference() { });
members.Add("_displayRect", new ResoniteLink.Reference() { });
members.Add("_desktopTexture", new ResoniteLink.Reference() { });
members.Add("_interactionRelay", new ResoniteLink.Reference() { });
members.Add("_currentControl", new ResoniteLink.Reference() { });
}

}
}
