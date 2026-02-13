
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FullBodyCalibratorDialog
// Generated on: pátek 13. února 2026 5:52:31
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_calibrator", new ResoniteLink.Reference() { });
members.Add("_currentPage", _currentPage.ToResoniteLinkField());
members.Add("_confirmTrackers", new ResoniteLink.Reference() { });
members.Add("_resetTrackers", new ResoniteLink.Reference() { });
members.Add("_calibrateAvatar", new ResoniteLink.Reference() { });
members.Add("_heightCompensation", new ResoniteLink.Reference() { });
members.Add("_useSymmetry", new ResoniteLink.Reference() { });
members.Add("_showBodyOverlay", new ResoniteLink.Reference() { });
members.Add("_showAvatarOverlay", new ResoniteLink.Reference() { });
members.Add("_hipsMapping", new ResoniteLink.Reference() { });
members.Add("_feetMapping", new ResoniteLink.Reference() { });
members.Add("_chestMapping", new ResoniteLink.Reference() { });
members.Add("_elbowsMapping", new ResoniteLink.Reference() { });
members.Add("_kneesMapping", new ResoniteLink.Reference() { });
members.Add("_heightField", new ResoniteLink.Reference() { });
members.Add("_heightWarning", new ResoniteLink.Reference() { });
members.Add("_useImperial", _useImperial.ToResoniteLinkField());
members.Add("_swapRegion", new ResoniteLink.Reference() { });
}

}
}
