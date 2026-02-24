
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibratorDialog
// Generated on: úterý 24. února 2026 18:20:21
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.FullBodyCalibrator _calibrator;
public global::FrooxEngine.FullBodyCalibratorDialog.Page _currentPage;
public global::FrooxEngine.UIX.Button _confirmTrackers;
public global::FrooxEngine.UIX.Button _resetTrackers;
public global::FrooxEngine.UIX.Button _calibrateAvatar;
public global::FrooxEngine.UIX.Slider<global::System.Single> _heightCompensation;
public global::FrooxEngine.UIX.Checkbox _useSymmetry;
public global::FrooxEngine.UIX.Checkbox _showBodyOverlay;
public global::FrooxEngine.UIX.Checkbox _showAvatarOverlay;
public global::FrooxEngine.UIX.Text _hipsMapping;
public global::FrooxEngine.UIX.Text _feetMapping;
public global::FrooxEngine.UIX.Text _chestMapping;
public global::FrooxEngine.UIX.Text _elbowsMapping;
public global::FrooxEngine.UIX.Text _kneesMapping;
public global::FrooxEngine.QuantityTextEditorParser<global::Elements.Quantity.Distance,global::System.Single> _heightField;
public global::FrooxEngine.UIX.Text _heightWarning;
public global::System.Boolean _useImperial;
public global::FrooxEngine.UIX.SlideSwapRegion _swapRegion;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_calibrator", _calibrator.ToResoniteReference(context));
members.Add("_currentPage", _currentPage.ToResoniteLinkField());
members.Add("_confirmTrackers", _confirmTrackers.ToResoniteReference(context));
members.Add("_resetTrackers", _resetTrackers.ToResoniteReference(context));
members.Add("_calibrateAvatar", _calibrateAvatar.ToResoniteReference(context));
members.Add("_heightCompensation", _heightCompensation.ToResoniteReference(context));
members.Add("_useSymmetry", _useSymmetry.ToResoniteReference(context));
members.Add("_showBodyOverlay", _showBodyOverlay.ToResoniteReference(context));
members.Add("_showAvatarOverlay", _showAvatarOverlay.ToResoniteReference(context));
members.Add("_hipsMapping", _hipsMapping.ToResoniteReference(context));
members.Add("_feetMapping", _feetMapping.ToResoniteReference(context));
members.Add("_chestMapping", _chestMapping.ToResoniteReference(context));
members.Add("_elbowsMapping", _elbowsMapping.ToResoniteReference(context));
members.Add("_kneesMapping", _kneesMapping.ToResoniteReference(context));
members.Add("_heightField", _heightField.ToResoniteReference(context));
members.Add("_heightWarning", _heightWarning.ToResoniteReference(context));
members.Add("_useImperial", _useImperial.ToResoniteLinkField());
members.Add("_swapRegion", _swapRegion.ToResoniteReference(context));
}

}
}
