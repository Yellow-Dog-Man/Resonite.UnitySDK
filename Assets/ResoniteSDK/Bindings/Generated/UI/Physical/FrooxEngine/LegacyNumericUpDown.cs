
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyNumericUpDown
// Generated on: čtvrtek 19. února 2026 8:00:25
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.IField<global::System.Single> DriveField;
public global::System.Boolean AllowWriteBack;
public global::System.Single Value;
public global::System.Int32 DecimalPoints;
public global::System.Single MinValue;
public global::System.Single MaxValue;
public global::System.Single IncrementValue;
public global::System.Boolean IsEnabled;
public global::FrooxEngine.IField<global::System.String> _textDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DriveField", DriveField.ToResoniteReference(context));
members.Add("AllowWriteBack", AllowWriteBack.ToResoniteLinkField());
members.Add("Value", Value.ToResoniteLinkField());
members.Add("DecimalPoints", DecimalPoints.ToResoniteLinkField());
members.Add("MinValue", MinValue.ToResoniteLinkField());
members.Add("MaxValue", MaxValue.ToResoniteLinkField());
members.Add("IncrementValue", IncrementValue.ToResoniteLinkField());
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("_textDrive", _textDrive.ToResoniteReference(context));
}

}
}
