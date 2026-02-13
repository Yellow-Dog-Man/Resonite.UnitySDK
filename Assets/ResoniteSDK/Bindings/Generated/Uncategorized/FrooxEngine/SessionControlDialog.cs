
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionControlDialog
// Generated on: pátek 13. února 2026 23:23:18
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ActiveTab", ActiveTab.ToResoniteLinkField());
members.Add("_contentRoot", new ResoniteLink.Reference() { });
members.Add("_worldName", new ResoniteLink.Reference() { });
members.Add("_maxUsers", new ResoniteLink.Reference() { });
members.Add("_awayKickEnabled", new ResoniteLink.Reference() { });
members.Add("_awayKickMinutes", new ResoniteLink.Reference() { });
members.Add("_autosaveEnabled", new ResoniteLink.Reference() { });
members.Add("_autosaveMinutes", new ResoniteLink.Reference() { });
members.Add("_autocleanEnabled", new ResoniteLink.Reference() { });
members.Add("_autocleanMinutes", new ResoniteLink.Reference() { });
members.Add("_mobileFriendly", new ResoniteLink.Reference() { });
members.Add("_hideFromListing", new ResoniteLink.Reference() { });
members.Add("_description", new ResoniteLink.Reference() { });
members.Add("_worldNameButton", new ResoniteLink.Reference() { });
members.Add("_descriptionButton", new ResoniteLink.Reference() { });
members.Add("_maxUsersButton", new ResoniteLink.Reference() { });
members.Add("_awayKickEnabledButton", new ResoniteLink.Reference() { });
members.Add("_awayKickMinutesButton", new ResoniteLink.Reference() { });
members.Add("_autosaveEnabledButton", new ResoniteLink.Reference() { });
members.Add("_autosaveMinutesButton", new ResoniteLink.Reference() { });
members.Add("_autocleanEnabledButton", new ResoniteLink.Reference() { });
members.Add("_autocleanMinutesButton", new ResoniteLink.Reference() { });
members.Add("_mobileFriendlyButton", new ResoniteLink.Reference() { });
members.Add("_hideFromListingButton", new ResoniteLink.Reference() { });
members.Add("_permissionOverridesIndicator", new ResoniteLink.Reference() { });
members.Add("_permissionOverridesButton", new ResoniteLink.Reference() { });
members.Add("_getSessionOrb", new ResoniteLink.Reference() { });
members.Add("_getWorldOrb", new ResoniteLink.Reference() { });
members.Add("_editMode", new ResoniteLink.Reference() { });
members.Add("_copySessionURL", new ResoniteLink.Reference() { });
members.Add("_copyWorldURL", new ResoniteLink.Reference() { });
members.Add("_copyRecordURL", new ResoniteLink.Reference() { });
members.Add("_accessLevelRadios", new ResoniteLink.SyncList()
{
    Elements = _accessLevelRadios.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_accessLevelRadiosButtons", new ResoniteLink.SyncList()
{
    Elements = _accessLevelRadiosButtons.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_worldNameSync", new ResoniteLink.Reference() { });
members.Add("_descriptionSync", new ResoniteLink.Reference() { });
members.Add("_maxUsersSync", new ResoniteLink.Reference() { });
members.Add("_awayKickEnabledSync", new ResoniteLink.Reference() { });
members.Add("_awayKickMinutesSync", new ResoniteLink.Reference() { });
members.Add("_autosaveEnabledSync", new ResoniteLink.Reference() { });
members.Add("_autosaveMinutesSync", new ResoniteLink.Reference() { });
members.Add("_autocleanEnabledSync", new ResoniteLink.Reference() { });
members.Add("_autocleanSecondsSync", new ResoniteLink.Reference() { });
members.Add("_mobileFriendlySync", new ResoniteLink.Reference() { });
members.Add("_hideFromListingSync", new ResoniteLink.Reference() { });
members.Add("_editModeSync", new ResoniteLink.Reference() { });
members.Add("_accessLevelSync", new ResoniteLink.Reference() { });
members.Add("_customVerifierLabel", new ResoniteLink.Reference() { });
members.Add("_customVerifierCheckbox", new ResoniteLink.Reference() { });
members.Add("_customVerifierButton", new ResoniteLink.Reference() { });
members.Add("_customVerifierSync", new ResoniteLink.Reference() { });
members.Add("_uiContentRoot", new ResoniteLink.Reference() { });
members.Add("_slideSwap", new ResoniteLink.Reference() { });
members.Add("_saveWorld", new ResoniteLink.Reference() { });
members.Add("_saveWorldAs", new ResoniteLink.Reference() { });
members.Add("_saveWorldCopy", new ResoniteLink.Reference() { });
members.Add("_enableResoniteLink", new ResoniteLink.Reference() { });
members.Add("_resoniteLinkPort", new ResoniteLink.Reference() { });
members.Add("_tabButtons", new ResoniteLink.SyncList()
{
    Elements = _tabButtons.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}
