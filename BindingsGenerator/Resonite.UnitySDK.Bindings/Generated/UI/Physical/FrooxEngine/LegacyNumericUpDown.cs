
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyNumericUpDown
// Generated on: čtvrtek 26. února 2026 12:28:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyNumericUpDown")]
public partial class LegacyNumericUpDown : global::FrooxEngine.LegacyFieldBase, global::FrooxEngine.INumericUpDown, global::FrooxEngine.ILegacyUIElement

{
    public global::FrooxEngine.IField<global::System.Single> DriveField { get => DriveField_Element.Data; set => DriveField_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> DriveField_Element = new();
public global::System.Boolean AllowWriteBack { get => AllowWriteBack_Element.Data; set => AllowWriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowWriteBack_Element = new();
public global::System.Single Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Value_Element = new();
public global::System.Int32 DecimalPoints { get => DecimalPoints_Element.Data; set => DecimalPoints_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> DecimalPoints_Element = new();
public global::System.Single MinValue { get => MinValue_Element.Data; set => MinValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinValue_Element = new();
public global::System.Single MaxValue { get => MaxValue_Element.Data; set => MaxValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxValue_Element = new();
public global::System.Single IncrementValue { get => IncrementValue_Element.Data; set => IncrementValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> IncrementValue_Element = new();
public global::System.Boolean IsEnabled { get => IsEnabled_Element.Data; set => IsEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsEnabled_Element = new();
public global::FrooxEngine.IField<global::System.String> _textDrive { get => _textDrive_Element.Data; set => _textDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _textDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DriveField", DriveField_Element.ToLinkReference(context));
members.Add("AllowWriteBack", AllowWriteBack_Element.ToLinkField(context));
members.Add("Value", Value_Element.ToLinkField(context));
members.Add("DecimalPoints", DecimalPoints_Element.ToLinkField(context));
members.Add("MinValue", MinValue_Element.ToLinkField(context));
members.Add("MaxValue", MaxValue_Element.ToLinkField(context));
members.Add("IncrementValue", IncrementValue_Element.ToLinkField(context));
members.Add("IsEnabled", IsEnabled_Element.ToLinkField(context));
members.Add("_textDrive", _textDrive_Element.ToLinkReference(context));
}

}
}
