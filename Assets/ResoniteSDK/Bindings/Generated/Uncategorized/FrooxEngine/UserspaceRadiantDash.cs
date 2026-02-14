
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceRadiantDash
// Generated on: sobota 14. února 2026 8:58:46
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlockOpenClose", BlockOpenClose.ToResoniteLinkField());
members.Add("Freeform", Freeform.ToResoniteLinkField());
members.Add("_dash", _dash.ToResoniteReference(context));
members.Add("_dashVisualRoot", _dashVisualRoot.ToResoniteReference(context));
members.Add("_positioner", _positioner.ToResoniteReference(context));
members.Add("_modalOverlay", _modalOverlay.ToResoniteReference(context));
members.Add("_legacyInventoryPanel", _legacyInventoryPanel.ToResoniteReference(context));
members.Add("_legacyInventory", _legacyInventory.ToResoniteReference(context));
members.Add("_slider", _slider.ToResoniteReference(context));
members.Add("_lookat", _lookat.ToResoniteReference(context));
members.Add("_uiEditModeToggle", _uiEditModeToggle.ToResoniteReference(context));
members.Add("_alwaysOnFacetRoot", _alwaysOnFacetRoot.ToResoniteReference(context));
members.Add("_screensWorkspace", _screensWorkspace.ToResoniteReference(context));
members.Add("_topWorkspace", _topWorkspace.ToResoniteReference(context));
members.Add("_notifications", _notifications.ToResoniteReference(context));
members.Add("_notificationsRoot", _notificationsRoot.ToResoniteReference(context));
members.Add("_notificationsHolder", _notificationsHolder.ToResoniteReference(context));
}

}
}
