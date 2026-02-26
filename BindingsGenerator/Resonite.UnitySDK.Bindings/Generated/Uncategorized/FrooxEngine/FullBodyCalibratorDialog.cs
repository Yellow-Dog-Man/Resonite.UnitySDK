
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibratorDialog
// Generated on: čtvrtek 26. února 2026 12:28:10
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FullBodyCalibratorDialog")]
public partial class FullBodyCalibratorDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.FullBodyCalibrator _calibrator { get => _calibrator_Element.Data; set => _calibrator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FullBodyCalibrator>, global::FrooxEngine.FullBodyCalibrator> _calibrator_Element = new();
public global::FrooxEngine.FullBodyCalibratorDialog.Page _currentPage { get => _currentPage_Element.Data; set => _currentPage_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FullBodyCalibratorDialog.Page>, global::FrooxEngine.FullBodyCalibratorDialog.Page> _currentPage_Element = new();
public global::FrooxEngine.UIX.Button _confirmTrackers { get => _confirmTrackers_Element.Data; set => _confirmTrackers_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _confirmTrackers_Element = new();
public global::FrooxEngine.UIX.Button _resetTrackers { get => _resetTrackers_Element.Data; set => _resetTrackers_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _resetTrackers_Element = new();
public global::FrooxEngine.UIX.Button _calibrateAvatar { get => _calibrateAvatar_Element.Data; set => _calibrateAvatar_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _calibrateAvatar_Element = new();
public global::FrooxEngine.UIX.Slider<global::System.Single> _heightCompensation { get => _heightCompensation_Element.Data; set => _heightCompensation_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Slider<global::System.Single>>, global::FrooxEngine.UIX.Slider<global::System.Single>> _heightCompensation_Element = new();
public global::FrooxEngine.UIX.Checkbox _useSymmetry { get => _useSymmetry_Element.Data; set => _useSymmetry_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _useSymmetry_Element = new();
public global::FrooxEngine.UIX.Checkbox _showBodyOverlay { get => _showBodyOverlay_Element.Data; set => _showBodyOverlay_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _showBodyOverlay_Element = new();
public global::FrooxEngine.UIX.Checkbox _showAvatarOverlay { get => _showAvatarOverlay_Element.Data; set => _showAvatarOverlay_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _showAvatarOverlay_Element = new();
public global::FrooxEngine.UIX.Text _hipsMapping { get => _hipsMapping_Element.Data; set => _hipsMapping_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _hipsMapping_Element = new();
public global::FrooxEngine.UIX.Text _feetMapping { get => _feetMapping_Element.Data; set => _feetMapping_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _feetMapping_Element = new();
public global::FrooxEngine.UIX.Text _chestMapping { get => _chestMapping_Element.Data; set => _chestMapping_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _chestMapping_Element = new();
public global::FrooxEngine.UIX.Text _elbowsMapping { get => _elbowsMapping_Element.Data; set => _elbowsMapping_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _elbowsMapping_Element = new();
public global::FrooxEngine.UIX.Text _kneesMapping { get => _kneesMapping_Element.Data; set => _kneesMapping_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _kneesMapping_Element = new();
public global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance,global::System.Single> _heightField { get => _heightField_Element.Data; set => _heightField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance,global::System.Single>>, global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance,global::System.Single>> _heightField_Element = new();
public global::FrooxEngine.UIX.Text _heightWarning { get => _heightWarning_Element.Data; set => _heightWarning_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _heightWarning_Element = new();
public global::System.Boolean _useImperial { get => _useImperial_Element.Data; set => _useImperial_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _useImperial_Element = new();
public global::FrooxEngine.UIX.SlideSwapRegion _swapRegion { get => _swapRegion_Element.Data; set => _swapRegion_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.SlideSwapRegion>, global::FrooxEngine.UIX.SlideSwapRegion> _swapRegion_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_calibrator", _calibrator_Element.ToLinkReference(context));
members.Add("_currentPage", _currentPage_Element.ToLinkField(context));
members.Add("_confirmTrackers", _confirmTrackers_Element.ToLinkReference(context));
members.Add("_resetTrackers", _resetTrackers_Element.ToLinkReference(context));
members.Add("_calibrateAvatar", _calibrateAvatar_Element.ToLinkReference(context));
members.Add("_heightCompensation", _heightCompensation_Element.ToLinkReference(context));
members.Add("_useSymmetry", _useSymmetry_Element.ToLinkReference(context));
members.Add("_showBodyOverlay", _showBodyOverlay_Element.ToLinkReference(context));
members.Add("_showAvatarOverlay", _showAvatarOverlay_Element.ToLinkReference(context));
members.Add("_hipsMapping", _hipsMapping_Element.ToLinkReference(context));
members.Add("_feetMapping", _feetMapping_Element.ToLinkReference(context));
members.Add("_chestMapping", _chestMapping_Element.ToLinkReference(context));
members.Add("_elbowsMapping", _elbowsMapping_Element.ToLinkReference(context));
members.Add("_kneesMapping", _kneesMapping_Element.ToLinkReference(context));
members.Add("_heightField", _heightField_Element.ToLinkReference(context));
members.Add("_heightWarning", _heightWarning_Element.ToLinkReference(context));
members.Add("_useImperial", _useImperial_Element.ToLinkField(context));
members.Add("_swapRegion", _swapRegion_Element.ToLinkReference(context));
}

}
}
