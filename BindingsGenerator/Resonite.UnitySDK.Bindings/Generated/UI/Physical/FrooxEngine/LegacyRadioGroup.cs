
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyRadioGroup
// Generated on: středa 25. února 2026 16:14:33
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("_selectedOption", _selectedOption.ToResoniteReference(context));
members.Add("_choiceVisual", _choiceVisual.ToResoniteReference(context));
members.Add("_choicePosition", _choicePosition.ToResoniteReference(context));
members.Add("_choiceRotation", _choiceRotation.ToResoniteReference(context));
members.Add("_choiceScale", _choiceScale.ToResoniteReference(context));
members.Add("_choiceMaterial", _choiceMaterial.ToResoniteReference(context));
}

}
}
