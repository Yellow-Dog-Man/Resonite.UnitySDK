
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyRadioGroup
// Generated on: pátek 13. února 2026 23:23:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyRadioGroup")]
public partial class LegacyRadioGroup : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.IRadioGroup, global::FrooxEngine.ILegacyUIElement

{
    public global::System.Boolean IsEnabled;
public global::FrooxEngine.LegacyRadio _selectedOption;
public global::FrooxEngine.Slot _choiceVisual;
public global::FrooxEngine.IField<UnityEngine.Vector3> _choicePosition;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _choiceRotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _choiceScale;
public global::FrooxEngine.PBS_RimMetallic _choiceMaterial;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("_selectedOption", new ResoniteLink.Reference() { });
members.Add("_choiceVisual", new ResoniteLink.Reference() { });
members.Add("_choicePosition", new ResoniteLink.Reference() { });
members.Add("_choiceRotation", new ResoniteLink.Reference() { });
members.Add("_choiceScale", new ResoniteLink.Reference() { });
members.Add("_choiceMaterial", new ResoniteLink.Reference() { });
}

}
}
