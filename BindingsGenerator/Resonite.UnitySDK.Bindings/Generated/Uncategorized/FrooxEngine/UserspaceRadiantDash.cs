
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceRadiantDash
// Generated on: čtvrtek 26. února 2026 10:04:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserspaceRadiantDash")]
public partial class UserspaceRadiantDash : global::FrooxEngine.Component

{
    public global::System.Boolean BlockOpenClose { get => BlockOpenClose_Element.Data; set => BlockOpenClose_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> BlockOpenClose_Element = new();
public global::System.Boolean Freeform { get => Freeform_Element.Data; set => Freeform_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Freeform_Element = new();
public global::FrooxEngine.RadiantDash _dash { get => _dash_Element.Data; set => _dash_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantDash>, global::FrooxEngine.RadiantDash> _dash_Element = new();
public global::FrooxEngine.Slot _dashVisualRoot { get => _dashVisualRoot_Element.Data; set => _dashVisualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _dashVisualRoot_Element = new();
public global::FrooxEngine.UserInterfacePositioner _positioner { get => _positioner_Element.Data; set => _positioner_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UserInterfacePositioner>, global::FrooxEngine.UserInterfacePositioner> _positioner_Element = new();
public global::FrooxEngine.ModalOverlayManager _modalOverlay { get => _modalOverlay_Element.Data; set => _modalOverlay_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ModalOverlayManager>, global::FrooxEngine.ModalOverlayManager> _modalOverlay_Element = new();
public global::FrooxEngine.LegacyCanvasPanel _legacyInventoryPanel { get => _legacyInventoryPanel_Element.Data; set => _legacyInventoryPanel_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyCanvasPanel>, global::FrooxEngine.LegacyCanvasPanel> _legacyInventoryPanel_Element = new();
public global::FrooxEngine.InventoryBrowser _legacyInventory { get => _legacyInventory_Element.Data; set => _legacyInventory_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.InventoryBrowser>, global::FrooxEngine.InventoryBrowser> _legacyInventory_Element = new();
public global::FrooxEngine.Slider _slider { get => _slider_Element.Data; set => _slider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slider>, global::FrooxEngine.Slider> _slider_Element = new();
public global::FrooxEngine.LookAt _lookat { get => _lookat_Element.Data; set => _lookat_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LookAt>, global::FrooxEngine.LookAt> _lookat_Element = new();
public global::FrooxEngine.Slot _uiEditModeToggle { get => _uiEditModeToggle_Element.Data; set => _uiEditModeToggle_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _uiEditModeToggle_Element = new();
public global::FrooxEngine.Slot _alwaysOnFacetRoot { get => _alwaysOnFacetRoot_Element.Data; set => _alwaysOnFacetRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _alwaysOnFacetRoot_Element = new();
public global::FrooxEngine.Workspace _screensWorkspace { get => _screensWorkspace_Element.Data; set => _screensWorkspace_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Workspace>, global::FrooxEngine.Workspace> _screensWorkspace_Element = new();
public global::FrooxEngine.Workspace _topWorkspace { get => _topWorkspace_Element.Data; set => _topWorkspace_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Workspace>, global::FrooxEngine.Workspace> _topWorkspace_Element = new();
public global::FrooxEngine.NotificationPanel _notifications { get => _notifications_Element.Data; set => _notifications_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.NotificationPanel>, global::FrooxEngine.NotificationPanel> _notifications_Element = new();
public global::FrooxEngine.Slot _notificationsRoot { get => _notificationsRoot_Element.Data; set => _notificationsRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _notificationsRoot_Element = new();
public global::FrooxEngine.Slot _notificationsHolder { get => _notificationsHolder_Element.Data; set => _notificationsHolder_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _notificationsHolder_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlockOpenClose", BlockOpenClose_Element.Data.ToResoniteLinkField());
members.Add("Freeform", Freeform_Element.Data.ToResoniteLinkField());
members.Add("_dash", _dash_Element.Data.ToResoniteReference(context));
members.Add("_dashVisualRoot", _dashVisualRoot_Element.Data.ToResoniteReference(context));
members.Add("_positioner", _positioner_Element.Data.ToResoniteReference(context));
members.Add("_modalOverlay", _modalOverlay_Element.Data.ToResoniteReference(context));
members.Add("_legacyInventoryPanel", _legacyInventoryPanel_Element.Data.ToResoniteReference(context));
members.Add("_legacyInventory", _legacyInventory_Element.Data.ToResoniteReference(context));
members.Add("_slider", _slider_Element.Data.ToResoniteReference(context));
members.Add("_lookat", _lookat_Element.Data.ToResoniteReference(context));
members.Add("_uiEditModeToggle", _uiEditModeToggle_Element.Data.ToResoniteReference(context));
members.Add("_alwaysOnFacetRoot", _alwaysOnFacetRoot_Element.Data.ToResoniteReference(context));
members.Add("_screensWorkspace", _screensWorkspace_Element.Data.ToResoniteReference(context));
members.Add("_topWorkspace", _topWorkspace_Element.Data.ToResoniteReference(context));
members.Add("_notifications", _notifications_Element.Data.ToResoniteReference(context));
members.Add("_notificationsRoot", _notificationsRoot_Element.Data.ToResoniteReference(context));
members.Add("_notificationsHolder", _notificationsHolder_Element.Data.ToResoniteReference(context));
}

}
}
