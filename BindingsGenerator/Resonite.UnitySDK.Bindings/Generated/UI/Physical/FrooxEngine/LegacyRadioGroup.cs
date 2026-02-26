
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyRadioGroup
// Generated on: čtvrtek 26. února 2026 15:09:09
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Boolean IsEnabled { get => IsEnabled_Element.Data; set => IsEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsEnabled_Element = new();
public global::FrooxEngine.LegacyRadio _selectedOption { get => _selectedOption_Element.Data; set => _selectedOption_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyRadio>, global::FrooxEngine.LegacyRadio> _selectedOption_Element = new();
public global::FrooxEngine.Slot _choiceVisual { get => _choiceVisual_Element.Data; set => _choiceVisual_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _choiceVisual_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _choicePosition { get => _choicePosition_Element.Data; set => _choicePosition_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _choicePosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _choiceRotation { get => _choiceRotation_Element.Data; set => _choiceRotation_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _choiceRotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _choiceScale { get => _choiceScale_Element.Data; set => _choiceScale_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _choiceScale_Element = new();
public global::FrooxEngine.PBS_RimMetallic _choiceMaterial { get => _choiceMaterial_Element.Data; set => _choiceMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _choiceMaterial_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsEnabled", IsEnabled_Element.ToLinkField(context));
members.Add("_selectedOption", _selectedOption_Element.ToLinkReference(context));
members.Add("_choiceVisual", _choiceVisual_Element.ToLinkReference(context));
members.Add("_choicePosition", _choicePosition_Element.ToLinkReference(context));
members.Add("_choiceRotation", _choiceRotation_Element.ToLinkReference(context));
members.Add("_choiceScale", _choiceScale_Element.ToLinkReference(context));
members.Add("_choiceMaterial", _choiceMaterial_Element.ToLinkReference(context));
}

}
}
