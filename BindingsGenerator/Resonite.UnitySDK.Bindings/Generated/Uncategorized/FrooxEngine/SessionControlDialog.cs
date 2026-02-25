
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionControlDialog
// Generated on: středa 25. února 2026 16:14:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SessionControlDialog")]
public partial class SessionControlDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.SessionControlDialog.Tab ActiveTab;
public global::FrooxEngine.Slot _contentRoot;
public global::FrooxEngine.UIX.TextField _worldName;
public global::FrooxEngine.IntTextEditorParser _maxUsers;
public global::FrooxEngine.UIX.Checkbox _awayKickEnabled;
public global::FrooxEngine.FloatTextEditorParser _awayKickMinutes;
public global::FrooxEngine.UIX.Checkbox _autosaveEnabled;
public global::FrooxEngine.FloatTextEditorParser _autosaveMinutes;
public global::FrooxEngine.UIX.Checkbox _autocleanEnabled;
public global::FrooxEngine.FloatTextEditorParser _autocleanMinutes;
public global::FrooxEngine.UIX.Checkbox _mobileFriendly;
public global::FrooxEngine.UIX.Checkbox _hideFromListing;
public global::FrooxEngine.UIX.TextField _description;
public global::FrooxEngine.UIX.Button _worldNameButton;
public global::FrooxEngine.UIX.Button _descriptionButton;
public global::FrooxEngine.UIX.Button _maxUsersButton;
public global::FrooxEngine.UIX.Button _awayKickEnabledButton;
public global::FrooxEngine.UIX.Button _awayKickMinutesButton;
public global::FrooxEngine.UIX.Button _autosaveEnabledButton;
public global::FrooxEngine.UIX.Button _autosaveMinutesButton;
public global::FrooxEngine.UIX.Button _autocleanEnabledButton;
public global::FrooxEngine.UIX.Button _autocleanMinutesButton;
public global::FrooxEngine.UIX.Button _mobileFriendlyButton;
public global::FrooxEngine.UIX.Button _hideFromListingButton;
public global::FrooxEngine.UIX.Text _permissionOverridesIndicator;
public global::FrooxEngine.UIX.Button _permissionOverridesButton;
public global::FrooxEngine.UIX.Button _getSessionOrb;
public global::FrooxEngine.UIX.Button _getWorldOrb;
public global::FrooxEngine.UIX.Button _editMode;
public global::FrooxEngine.UIX.Button _copySessionURL;
public global::FrooxEngine.UIX.Button _copyWorldURL;
public global::FrooxEngine.UIX.Button _copyRecordURL;
public System.Collections.Generic.List<global::FrooxEngine.UIX.Radio> _accessLevelRadios;
public System.Collections.Generic.List<global::FrooxEngine.UIX.Button> _accessLevelRadiosButtons;
public global::FrooxEngine.WorldValueSync<global::System.String> _worldNameSync;
public global::FrooxEngine.WorldValueSync<global::System.String> _descriptionSync;
public global::FrooxEngine.WorldValueSync<global::System.Int32> _maxUsersSync;
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _awayKickEnabledSync;
public global::FrooxEngine.WorldValueSync<global::System.Single> _awayKickMinutesSync;
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _autosaveEnabledSync;
public global::FrooxEngine.WorldValueSync<global::System.Single> _autosaveMinutesSync;
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _autocleanEnabledSync;
public global::FrooxEngine.WorldValueSync<global::System.Single> _autocleanSecondsSync;
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _mobileFriendlySync;
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _hideFromListingSync;
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _editModeSync;
public global::FrooxEngine.WorldValueSync<global::SkyFrost.Base.SessionAccessLevel> _accessLevelSync;
public global::FrooxEngine.UIX.Text _customVerifierLabel;
public global::FrooxEngine.UIX.Checkbox _customVerifierCheckbox;
public global::FrooxEngine.UIX.Button _customVerifierButton;
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _customVerifierSync;
public global::FrooxEngine.Slot _uiContentRoot;
public global::FrooxEngine.UIX.SlideSwapRegion _slideSwap;
public global::FrooxEngine.UIX.Button _saveWorld;
public global::FrooxEngine.UIX.Button _saveWorldAs;
public global::FrooxEngine.UIX.Button _saveWorldCopy;
public global::FrooxEngine.UIX.Button _enableResoniteLink;
public global::FrooxEngine.UIX.Text _resoniteLinkPort;
public System.Collections.Generic.List<global::FrooxEngine.UIX.Button> _tabButtons;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ActiveTab", ActiveTab.ToResoniteLinkField());
members.Add("_contentRoot", _contentRoot.ToResoniteReference(context));
members.Add("_worldName", _worldName.ToResoniteReference(context));
members.Add("_maxUsers", _maxUsers.ToResoniteReference(context));
members.Add("_awayKickEnabled", _awayKickEnabled.ToResoniteReference(context));
members.Add("_awayKickMinutes", _awayKickMinutes.ToResoniteReference(context));
members.Add("_autosaveEnabled", _autosaveEnabled.ToResoniteReference(context));
members.Add("_autosaveMinutes", _autosaveMinutes.ToResoniteReference(context));
members.Add("_autocleanEnabled", _autocleanEnabled.ToResoniteReference(context));
members.Add("_autocleanMinutes", _autocleanMinutes.ToResoniteReference(context));
members.Add("_mobileFriendly", _mobileFriendly.ToResoniteReference(context));
members.Add("_hideFromListing", _hideFromListing.ToResoniteReference(context));
members.Add("_description", _description.ToResoniteReference(context));
members.Add("_worldNameButton", _worldNameButton.ToResoniteReference(context));
members.Add("_descriptionButton", _descriptionButton.ToResoniteReference(context));
members.Add("_maxUsersButton", _maxUsersButton.ToResoniteReference(context));
members.Add("_awayKickEnabledButton", _awayKickEnabledButton.ToResoniteReference(context));
members.Add("_awayKickMinutesButton", _awayKickMinutesButton.ToResoniteReference(context));
members.Add("_autosaveEnabledButton", _autosaveEnabledButton.ToResoniteReference(context));
members.Add("_autosaveMinutesButton", _autosaveMinutesButton.ToResoniteReference(context));
members.Add("_autocleanEnabledButton", _autocleanEnabledButton.ToResoniteReference(context));
members.Add("_autocleanMinutesButton", _autocleanMinutesButton.ToResoniteReference(context));
members.Add("_mobileFriendlyButton", _mobileFriendlyButton.ToResoniteReference(context));
members.Add("_hideFromListingButton", _hideFromListingButton.ToResoniteReference(context));
members.Add("_permissionOverridesIndicator", _permissionOverridesIndicator.ToResoniteReference(context));
members.Add("_permissionOverridesButton", _permissionOverridesButton.ToResoniteReference(context));
members.Add("_getSessionOrb", _getSessionOrb.ToResoniteReference(context));
members.Add("_getWorldOrb", _getWorldOrb.ToResoniteReference(context));
members.Add("_editMode", _editMode.ToResoniteReference(context));
members.Add("_copySessionURL", _copySessionURL.ToResoniteReference(context));
members.Add("_copyWorldURL", _copyWorldURL.ToResoniteReference(context));
members.Add("_copyRecordURL", _copyRecordURL.ToResoniteReference(context));
members.Add("_accessLevelRadios", new ResoniteLink.SyncList()
{
    Elements = _accessLevelRadios.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_accessLevelRadiosButtons", new ResoniteLink.SyncList()
{
    Elements = _accessLevelRadiosButtons.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_worldNameSync", _worldNameSync.ToResoniteReference(context));
members.Add("_descriptionSync", _descriptionSync.ToResoniteReference(context));
members.Add("_maxUsersSync", _maxUsersSync.ToResoniteReference(context));
members.Add("_awayKickEnabledSync", _awayKickEnabledSync.ToResoniteReference(context));
members.Add("_awayKickMinutesSync", _awayKickMinutesSync.ToResoniteReference(context));
members.Add("_autosaveEnabledSync", _autosaveEnabledSync.ToResoniteReference(context));
members.Add("_autosaveMinutesSync", _autosaveMinutesSync.ToResoniteReference(context));
members.Add("_autocleanEnabledSync", _autocleanEnabledSync.ToResoniteReference(context));
members.Add("_autocleanSecondsSync", _autocleanSecondsSync.ToResoniteReference(context));
members.Add("_mobileFriendlySync", _mobileFriendlySync.ToResoniteReference(context));
members.Add("_hideFromListingSync", _hideFromListingSync.ToResoniteReference(context));
members.Add("_editModeSync", _editModeSync.ToResoniteReference(context));
members.Add("_accessLevelSync", _accessLevelSync.ToResoniteReference(context));
members.Add("_customVerifierLabel", _customVerifierLabel.ToResoniteReference(context));
members.Add("_customVerifierCheckbox", _customVerifierCheckbox.ToResoniteReference(context));
members.Add("_customVerifierButton", _customVerifierButton.ToResoniteReference(context));
members.Add("_customVerifierSync", _customVerifierSync.ToResoniteReference(context));
members.Add("_uiContentRoot", _uiContentRoot.ToResoniteReference(context));
members.Add("_slideSwap", _slideSwap.ToResoniteReference(context));
members.Add("_saveWorld", _saveWorld.ToResoniteReference(context));
members.Add("_saveWorldAs", _saveWorldAs.ToResoniteReference(context));
members.Add("_saveWorldCopy", _saveWorldCopy.ToResoniteReference(context));
members.Add("_enableResoniteLink", _enableResoniteLink.ToResoniteReference(context));
members.Add("_resoniteLinkPort", _resoniteLinkPort.ToResoniteReference(context));
members.Add("_tabButtons", new ResoniteLink.SyncList()
{
    Elements = _tabButtons.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
