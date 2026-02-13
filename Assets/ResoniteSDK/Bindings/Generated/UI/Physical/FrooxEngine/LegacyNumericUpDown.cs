
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyNumericUpDown
// Generated on: pátek 13. února 2026 5:52:28
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DriveField", new ResoniteLink.Reference() { });
members.Add("AllowWriteBack", AllowWriteBack.ToResoniteLinkField());
members.Add("Value", Value.ToResoniteLinkField());
members.Add("DecimalPoints", DecimalPoints.ToResoniteLinkField());
members.Add("MinValue", MinValue.ToResoniteLinkField());
members.Add("MaxValue", MaxValue.ToResoniteLinkField());
members.Add("IncrementValue", IncrementValue.ToResoniteLinkField());
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("_textDrive", new ResoniteLink.Reference() { });
}

}
}
