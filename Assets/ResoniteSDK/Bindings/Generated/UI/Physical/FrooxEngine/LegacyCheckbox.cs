
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyCheckbox
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyCheckbox")]
public partial class LegacyCheckbox : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.ICheckbox, global::FrooxEngine.ILegacyUIElement, global::FrooxEngine.ITouchable

{
    public global::System.Boolean IsChecked;
public global::System.Boolean IsEnabled;
public global::FrooxEngine.IField<global::System.Boolean> DriveField;
public global::System.Boolean AllowWriteBack;
public global::System.Single Size;
public global::System.Single BevelPercent;
public UnityEngine.ColorX Color;
public global::FrooxEngine.BevelBoxMesh _shellMesh;
public global::FrooxEngine.BevelBoxMesh _checkMesh;
public global::FrooxEngine.LegacyHorizontalChoiceBar _titleBar;
public global::FrooxEngine.IField<UnityEngine.Vector3> _shellSize;
public global::FrooxEngine.IField<global::System.Single> _shellBevel;
public global::FrooxEngine.IField<UnityEngine.Vector3> _checkSize;
public global::FrooxEngine.IField<global::System.Single> _checkBevel;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize;
public global::FrooxEngine.PBS_RimMetallic _shellMaterial;
public global::FrooxEngine.PBS_RimMetallic _checkMaterial;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsChecked", IsChecked.ToResoniteLinkField());
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("DriveField", new ResoniteLink.Reference() { });
members.Add("AllowWriteBack", AllowWriteBack.ToResoniteLinkField());
members.Add("Size", Size.ToResoniteLinkField());
members.Add("BevelPercent", BevelPercent.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("_shellMesh", new ResoniteLink.Reference() { });
members.Add("_checkMesh", new ResoniteLink.Reference() { });
members.Add("_titleBar", new ResoniteLink.Reference() { });
members.Add("_shellSize", new ResoniteLink.Reference() { });
members.Add("_shellBevel", new ResoniteLink.Reference() { });
members.Add("_checkSize", new ResoniteLink.Reference() { });
members.Add("_checkBevel", new ResoniteLink.Reference() { });
members.Add("_colliderSize", new ResoniteLink.Reference() { });
members.Add("_shellMaterial", new ResoniteLink.Reference() { });
members.Add("_checkMaterial", new ResoniteLink.Reference() { });
}

}
}
