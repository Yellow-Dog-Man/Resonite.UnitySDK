
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceRadiantDash
// Generated on: pátek 13. února 2026 23:23:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserspaceRadiantDash")]
public partial class UserspaceRadiantDash : global::FrooxEngine.Component

{
    public global::System.Boolean BlockOpenClose;
public global::System.Boolean Freeform;
public global::FrooxEngine.RadiantDash _dash;
public global::FrooxEngine.Slot _dashVisualRoot;
public global::FrooxEngine.UserInterfacePositioner _positioner;
public global::FrooxEngine.ModalOverlayManager _modalOverlay;
public global::FrooxEngine.LegacyCanvasPanel _legacyInventoryPanel;
public global::FrooxEngine.InventoryBrowser _legacyInventory;
public global::FrooxEngine.Slider _slider;
public global::FrooxEngine.LookAt _lookat;
public global::FrooxEngine.Slot _uiEditModeToggle;
public global::FrooxEngine.Slot _alwaysOnFacetRoot;
public global::FrooxEngine.Workspace _screensWorkspace;
public global::FrooxEngine.Workspace _topWorkspace;
public global::FrooxEngine.NotificationPanel _notifications;
public global::FrooxEngine.Slot _notificationsRoot;
public global::FrooxEngine.Slot _notificationsHolder;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BlockOpenClose", BlockOpenClose.ToResoniteLinkField());
members.Add("Freeform", Freeform.ToResoniteLinkField());
members.Add("_dash", new ResoniteLink.Reference() { });
members.Add("_dashVisualRoot", new ResoniteLink.Reference() { });
members.Add("_positioner", new ResoniteLink.Reference() { });
members.Add("_modalOverlay", new ResoniteLink.Reference() { });
members.Add("_legacyInventoryPanel", new ResoniteLink.Reference() { });
members.Add("_legacyInventory", new ResoniteLink.Reference() { });
members.Add("_slider", new ResoniteLink.Reference() { });
members.Add("_lookat", new ResoniteLink.Reference() { });
members.Add("_uiEditModeToggle", new ResoniteLink.Reference() { });
members.Add("_alwaysOnFacetRoot", new ResoniteLink.Reference() { });
members.Add("_screensWorkspace", new ResoniteLink.Reference() { });
members.Add("_topWorkspace", new ResoniteLink.Reference() { });
members.Add("_notifications", new ResoniteLink.Reference() { });
members.Add("_notificationsRoot", new ResoniteLink.Reference() { });
members.Add("_notificationsHolder", new ResoniteLink.Reference() { });
}

}
}
