
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionControlDialog
// Generated on: čtvrtek 26. února 2026 10:04:48
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
    public global::FrooxEngine.SessionControlDialog.Tab ActiveTab { get => ActiveTab_Element.Data; set => ActiveTab_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.SessionControlDialog.Tab>, global::FrooxEngine.SessionControlDialog.Tab> ActiveTab_Element = new();
public global::FrooxEngine.Slot _contentRoot { get => _contentRoot_Element.Data; set => _contentRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _contentRoot_Element = new();
public global::FrooxEngine.UIX.TextField _worldName { get => _worldName_Element.Data; set => _worldName_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _worldName_Element = new();
public global::FrooxEngine.IntTextEditorParser _maxUsers { get => _maxUsers_Element.Data; set => _maxUsers_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IntTextEditorParser>, global::FrooxEngine.IntTextEditorParser> _maxUsers_Element = new();
public global::FrooxEngine.UIX.Checkbox _awayKickEnabled { get => _awayKickEnabled_Element.Data; set => _awayKickEnabled_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _awayKickEnabled_Element = new();
public global::FrooxEngine.FloatTextEditorParser _awayKickMinutes { get => _awayKickMinutes_Element.Data; set => _awayKickMinutes_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> _awayKickMinutes_Element = new();
public global::FrooxEngine.UIX.Checkbox _autosaveEnabled { get => _autosaveEnabled_Element.Data; set => _autosaveEnabled_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _autosaveEnabled_Element = new();
public global::FrooxEngine.FloatTextEditorParser _autosaveMinutes { get => _autosaveMinutes_Element.Data; set => _autosaveMinutes_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> _autosaveMinutes_Element = new();
public global::FrooxEngine.UIX.Checkbox _autocleanEnabled { get => _autocleanEnabled_Element.Data; set => _autocleanEnabled_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _autocleanEnabled_Element = new();
public global::FrooxEngine.FloatTextEditorParser _autocleanMinutes { get => _autocleanMinutes_Element.Data; set => _autocleanMinutes_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> _autocleanMinutes_Element = new();
public global::FrooxEngine.UIX.Checkbox _mobileFriendly { get => _mobileFriendly_Element.Data; set => _mobileFriendly_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _mobileFriendly_Element = new();
public global::FrooxEngine.UIX.Checkbox _hideFromListing { get => _hideFromListing_Element.Data; set => _hideFromListing_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _hideFromListing_Element = new();
public global::FrooxEngine.UIX.TextField _description { get => _description_Element.Data; set => _description_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _description_Element = new();
public global::FrooxEngine.UIX.Button _worldNameButton { get => _worldNameButton_Element.Data; set => _worldNameButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _worldNameButton_Element = new();
public global::FrooxEngine.UIX.Button _descriptionButton { get => _descriptionButton_Element.Data; set => _descriptionButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _descriptionButton_Element = new();
public global::FrooxEngine.UIX.Button _maxUsersButton { get => _maxUsersButton_Element.Data; set => _maxUsersButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _maxUsersButton_Element = new();
public global::FrooxEngine.UIX.Button _awayKickEnabledButton { get => _awayKickEnabledButton_Element.Data; set => _awayKickEnabledButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _awayKickEnabledButton_Element = new();
public global::FrooxEngine.UIX.Button _awayKickMinutesButton { get => _awayKickMinutesButton_Element.Data; set => _awayKickMinutesButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _awayKickMinutesButton_Element = new();
public global::FrooxEngine.UIX.Button _autosaveEnabledButton { get => _autosaveEnabledButton_Element.Data; set => _autosaveEnabledButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _autosaveEnabledButton_Element = new();
public global::FrooxEngine.UIX.Button _autosaveMinutesButton { get => _autosaveMinutesButton_Element.Data; set => _autosaveMinutesButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _autosaveMinutesButton_Element = new();
public global::FrooxEngine.UIX.Button _autocleanEnabledButton { get => _autocleanEnabledButton_Element.Data; set => _autocleanEnabledButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _autocleanEnabledButton_Element = new();
public global::FrooxEngine.UIX.Button _autocleanMinutesButton { get => _autocleanMinutesButton_Element.Data; set => _autocleanMinutesButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _autocleanMinutesButton_Element = new();
public global::FrooxEngine.UIX.Button _mobileFriendlyButton { get => _mobileFriendlyButton_Element.Data; set => _mobileFriendlyButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _mobileFriendlyButton_Element = new();
public global::FrooxEngine.UIX.Button _hideFromListingButton { get => _hideFromListingButton_Element.Data; set => _hideFromListingButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _hideFromListingButton_Element = new();
public global::FrooxEngine.UIX.Text _permissionOverridesIndicator { get => _permissionOverridesIndicator_Element.Data; set => _permissionOverridesIndicator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _permissionOverridesIndicator_Element = new();
public global::FrooxEngine.UIX.Button _permissionOverridesButton { get => _permissionOverridesButton_Element.Data; set => _permissionOverridesButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _permissionOverridesButton_Element = new();
public global::FrooxEngine.UIX.Button _getSessionOrb { get => _getSessionOrb_Element.Data; set => _getSessionOrb_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _getSessionOrb_Element = new();
public global::FrooxEngine.UIX.Button _getWorldOrb { get => _getWorldOrb_Element.Data; set => _getWorldOrb_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _getWorldOrb_Element = new();
public global::FrooxEngine.UIX.Button _editMode { get => _editMode_Element.Data; set => _editMode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _editMode_Element = new();
public global::FrooxEngine.UIX.Button _copySessionURL { get => _copySessionURL_Element.Data; set => _copySessionURL_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _copySessionURL_Element = new();
public global::FrooxEngine.UIX.Button _copyWorldURL { get => _copyWorldURL_Element.Data; set => _copyWorldURL_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _copyWorldURL_Element = new();
public global::FrooxEngine.UIX.Button _copyRecordURL { get => _copyRecordURL_Element.Data; set => _copyRecordURL_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _copyRecordURL_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.UIX.Radio>, global::FrooxEngine.UIX.Radio, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Radio>, global::FrooxEngine.UIX.Radio>> _accessLevelRadios = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button>> _accessLevelRadiosButtons = new();
public global::FrooxEngine.WorldValueSync<global::System.String> _worldNameSync { get => _worldNameSync_Element.Data; set => _worldNameSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.String>>, global::FrooxEngine.WorldValueSync<global::System.String>> _worldNameSync_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.String> _descriptionSync { get => _descriptionSync_Element.Data; set => _descriptionSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.String>>, global::FrooxEngine.WorldValueSync<global::System.String>> _descriptionSync_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.Int32> _maxUsersSync { get => _maxUsersSync_Element.Data; set => _maxUsersSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.Int32>>, global::FrooxEngine.WorldValueSync<global::System.Int32>> _maxUsersSync_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _awayKickEnabledSync { get => _awayKickEnabledSync_Element.Data; set => _awayKickEnabledSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.Boolean>>, global::FrooxEngine.WorldValueSync<global::System.Boolean>> _awayKickEnabledSync_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.Single> _awayKickMinutesSync { get => _awayKickMinutesSync_Element.Data; set => _awayKickMinutesSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.Single>>, global::FrooxEngine.WorldValueSync<global::System.Single>> _awayKickMinutesSync_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _autosaveEnabledSync { get => _autosaveEnabledSync_Element.Data; set => _autosaveEnabledSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.Boolean>>, global::FrooxEngine.WorldValueSync<global::System.Boolean>> _autosaveEnabledSync_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.Single> _autosaveMinutesSync { get => _autosaveMinutesSync_Element.Data; set => _autosaveMinutesSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.Single>>, global::FrooxEngine.WorldValueSync<global::System.Single>> _autosaveMinutesSync_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _autocleanEnabledSync { get => _autocleanEnabledSync_Element.Data; set => _autocleanEnabledSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.Boolean>>, global::FrooxEngine.WorldValueSync<global::System.Boolean>> _autocleanEnabledSync_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.Single> _autocleanSecondsSync { get => _autocleanSecondsSync_Element.Data; set => _autocleanSecondsSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.Single>>, global::FrooxEngine.WorldValueSync<global::System.Single>> _autocleanSecondsSync_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _mobileFriendlySync { get => _mobileFriendlySync_Element.Data; set => _mobileFriendlySync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.Boolean>>, global::FrooxEngine.WorldValueSync<global::System.Boolean>> _mobileFriendlySync_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _hideFromListingSync { get => _hideFromListingSync_Element.Data; set => _hideFromListingSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.Boolean>>, global::FrooxEngine.WorldValueSync<global::System.Boolean>> _hideFromListingSync_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _editModeSync { get => _editModeSync_Element.Data; set => _editModeSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.Boolean>>, global::FrooxEngine.WorldValueSync<global::System.Boolean>> _editModeSync_Element = new();
public global::FrooxEngine.WorldValueSync<global::SkyFrost.Base.SessionAccessLevel> _accessLevelSync { get => _accessLevelSync_Element.Data; set => _accessLevelSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::SkyFrost.Base.SessionAccessLevel>>, global::FrooxEngine.WorldValueSync<global::SkyFrost.Base.SessionAccessLevel>> _accessLevelSync_Element = new();
public global::FrooxEngine.UIX.Text _customVerifierLabel { get => _customVerifierLabel_Element.Data; set => _customVerifierLabel_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _customVerifierLabel_Element = new();
public global::FrooxEngine.UIX.Checkbox _customVerifierCheckbox { get => _customVerifierCheckbox_Element.Data; set => _customVerifierCheckbox_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _customVerifierCheckbox_Element = new();
public global::FrooxEngine.UIX.Button _customVerifierButton { get => _customVerifierButton_Element.Data; set => _customVerifierButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _customVerifierButton_Element = new();
public global::FrooxEngine.WorldValueSync<global::System.Boolean> _customVerifierSync { get => _customVerifierSync_Element.Data; set => _customVerifierSync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldValueSync<global::System.Boolean>>, global::FrooxEngine.WorldValueSync<global::System.Boolean>> _customVerifierSync_Element = new();
public global::FrooxEngine.Slot _uiContentRoot { get => _uiContentRoot_Element.Data; set => _uiContentRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _uiContentRoot_Element = new();
public global::FrooxEngine.UIX.SlideSwapRegion _slideSwap { get => _slideSwap_Element.Data; set => _slideSwap_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.SlideSwapRegion>, global::FrooxEngine.UIX.SlideSwapRegion> _slideSwap_Element = new();
public global::FrooxEngine.UIX.Button _saveWorld { get => _saveWorld_Element.Data; set => _saveWorld_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _saveWorld_Element = new();
public global::FrooxEngine.UIX.Button _saveWorldAs { get => _saveWorldAs_Element.Data; set => _saveWorldAs_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _saveWorldAs_Element = new();
public global::FrooxEngine.UIX.Button _saveWorldCopy { get => _saveWorldCopy_Element.Data; set => _saveWorldCopy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _saveWorldCopy_Element = new();
public global::FrooxEngine.UIX.Button _enableResoniteLink { get => _enableResoniteLink_Element.Data; set => _enableResoniteLink_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _enableResoniteLink_Element = new();
public global::FrooxEngine.UIX.Text _resoniteLinkPort { get => _resoniteLinkPort_Element.Data; set => _resoniteLinkPort_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _resoniteLinkPort_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button>> _tabButtons = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ActiveTab", ActiveTab_Element.Data.ToResoniteLinkField());
members.Add("_contentRoot", _contentRoot_Element.Data.ToResoniteReference(context));
members.Add("_worldName", _worldName_Element.Data.ToResoniteReference(context));
members.Add("_maxUsers", _maxUsers_Element.Data.ToResoniteReference(context));
members.Add("_awayKickEnabled", _awayKickEnabled_Element.Data.ToResoniteReference(context));
members.Add("_awayKickMinutes", _awayKickMinutes_Element.Data.ToResoniteReference(context));
members.Add("_autosaveEnabled", _autosaveEnabled_Element.Data.ToResoniteReference(context));
members.Add("_autosaveMinutes", _autosaveMinutes_Element.Data.ToResoniteReference(context));
members.Add("_autocleanEnabled", _autocleanEnabled_Element.Data.ToResoniteReference(context));
members.Add("_autocleanMinutes", _autocleanMinutes_Element.Data.ToResoniteReference(context));
members.Add("_mobileFriendly", _mobileFriendly_Element.Data.ToResoniteReference(context));
members.Add("_hideFromListing", _hideFromListing_Element.Data.ToResoniteReference(context));
members.Add("_description", _description_Element.Data.ToResoniteReference(context));
members.Add("_worldNameButton", _worldNameButton_Element.Data.ToResoniteReference(context));
members.Add("_descriptionButton", _descriptionButton_Element.Data.ToResoniteReference(context));
members.Add("_maxUsersButton", _maxUsersButton_Element.Data.ToResoniteReference(context));
members.Add("_awayKickEnabledButton", _awayKickEnabledButton_Element.Data.ToResoniteReference(context));
members.Add("_awayKickMinutesButton", _awayKickMinutesButton_Element.Data.ToResoniteReference(context));
members.Add("_autosaveEnabledButton", _autosaveEnabledButton_Element.Data.ToResoniteReference(context));
members.Add("_autosaveMinutesButton", _autosaveMinutesButton_Element.Data.ToResoniteReference(context));
members.Add("_autocleanEnabledButton", _autocleanEnabledButton_Element.Data.ToResoniteReference(context));
members.Add("_autocleanMinutesButton", _autocleanMinutesButton_Element.Data.ToResoniteReference(context));
members.Add("_mobileFriendlyButton", _mobileFriendlyButton_Element.Data.ToResoniteReference(context));
members.Add("_hideFromListingButton", _hideFromListingButton_Element.Data.ToResoniteReference(context));
members.Add("_permissionOverridesIndicator", _permissionOverridesIndicator_Element.Data.ToResoniteReference(context));
members.Add("_permissionOverridesButton", _permissionOverridesButton_Element.Data.ToResoniteReference(context));
members.Add("_getSessionOrb", _getSessionOrb_Element.Data.ToResoniteReference(context));
members.Add("_getWorldOrb", _getWorldOrb_Element.Data.ToResoniteReference(context));
members.Add("_editMode", _editMode_Element.Data.ToResoniteReference(context));
members.Add("_copySessionURL", _copySessionURL_Element.Data.ToResoniteReference(context));
members.Add("_copyWorldURL", _copyWorldURL_Element.Data.ToResoniteReference(context));
members.Add("_copyRecordURL", _copyRecordURL_Element.Data.ToResoniteReference(context));
members.Add("_accessLevelRadios", new ResoniteLink.SyncList()
{
    Elements = _accessLevelRadios.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_accessLevelRadiosButtons", new ResoniteLink.SyncList()
{
    Elements = _accessLevelRadiosButtons.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_worldNameSync", _worldNameSync_Element.Data.ToResoniteReference(context));
members.Add("_descriptionSync", _descriptionSync_Element.Data.ToResoniteReference(context));
members.Add("_maxUsersSync", _maxUsersSync_Element.Data.ToResoniteReference(context));
members.Add("_awayKickEnabledSync", _awayKickEnabledSync_Element.Data.ToResoniteReference(context));
members.Add("_awayKickMinutesSync", _awayKickMinutesSync_Element.Data.ToResoniteReference(context));
members.Add("_autosaveEnabledSync", _autosaveEnabledSync_Element.Data.ToResoniteReference(context));
members.Add("_autosaveMinutesSync", _autosaveMinutesSync_Element.Data.ToResoniteReference(context));
members.Add("_autocleanEnabledSync", _autocleanEnabledSync_Element.Data.ToResoniteReference(context));
members.Add("_autocleanSecondsSync", _autocleanSecondsSync_Element.Data.ToResoniteReference(context));
members.Add("_mobileFriendlySync", _mobileFriendlySync_Element.Data.ToResoniteReference(context));
members.Add("_hideFromListingSync", _hideFromListingSync_Element.Data.ToResoniteReference(context));
members.Add("_editModeSync", _editModeSync_Element.Data.ToResoniteReference(context));
members.Add("_accessLevelSync", _accessLevelSync_Element.Data.ToResoniteReference(context));
members.Add("_customVerifierLabel", _customVerifierLabel_Element.Data.ToResoniteReference(context));
members.Add("_customVerifierCheckbox", _customVerifierCheckbox_Element.Data.ToResoniteReference(context));
members.Add("_customVerifierButton", _customVerifierButton_Element.Data.ToResoniteReference(context));
members.Add("_customVerifierSync", _customVerifierSync_Element.Data.ToResoniteReference(context));
members.Add("_uiContentRoot", _uiContentRoot_Element.Data.ToResoniteReference(context));
members.Add("_slideSwap", _slideSwap_Element.Data.ToResoniteReference(context));
members.Add("_saveWorld", _saveWorld_Element.Data.ToResoniteReference(context));
members.Add("_saveWorldAs", _saveWorldAs_Element.Data.ToResoniteReference(context));
members.Add("_saveWorldCopy", _saveWorldCopy_Element.Data.ToResoniteReference(context));
members.Add("_enableResoniteLink", _enableResoniteLink_Element.Data.ToResoniteReference(context));
members.Add("_resoniteLinkPort", _resoniteLinkPort_Element.Data.ToResoniteReference(context));
members.Add("_tabButtons", new ResoniteLink.SyncList()
{
    Elements = _tabButtons.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
}

}
}
