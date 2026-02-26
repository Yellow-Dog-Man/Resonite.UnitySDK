
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyCheckbox
// Generated on: čtvrtek 26. února 2026 10:04:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyCheckbox")]
public partial class LegacyCheckbox : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.ICheckbox, global::FrooxEngine.ILegacyUIElement, global::FrooxEngine.ITouchable

{
    public global::System.Boolean IsChecked { get => IsChecked_Element.Data; set => IsChecked_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsChecked_Element = new();
public global::System.Boolean IsEnabled { get => IsEnabled_Element.Data; set => IsEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsEnabled_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> DriveField { get => DriveField_Element.Data; set => DriveField_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> DriveField_Element = new();
public global::System.Boolean AllowWriteBack { get => AllowWriteBack_Element.Data; set => AllowWriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowWriteBack_Element = new();
public global::System.Single Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Size_Element = new();
public global::System.Single BevelPercent { get => BevelPercent_Element.Data; set => BevelPercent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BevelPercent_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::FrooxEngine.BevelBoxMesh _shellMesh { get => _shellMesh_Element.Data; set => _shellMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BevelBoxMesh>, global::FrooxEngine.BevelBoxMesh> _shellMesh_Element = new();
public global::FrooxEngine.BevelBoxMesh _checkMesh { get => _checkMesh_Element.Data; set => _checkMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BevelBoxMesh>, global::FrooxEngine.BevelBoxMesh> _checkMesh_Element = new();
public global::FrooxEngine.LegacyHorizontalChoiceBar _titleBar { get => _titleBar_Element.Data; set => _titleBar_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyHorizontalChoiceBar>, global::FrooxEngine.LegacyHorizontalChoiceBar> _titleBar_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _shellSize { get => _shellSize_Element.Data; set => _shellSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _shellSize_Element = new();
public global::FrooxEngine.IField<global::System.Single> _shellBevel { get => _shellBevel_Element.Data; set => _shellBevel_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _shellBevel_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _checkSize { get => _checkSize_Element.Data; set => _checkSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _checkSize_Element = new();
public global::FrooxEngine.IField<global::System.Single> _checkBevel { get => _checkBevel_Element.Data; set => _checkBevel_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _checkBevel_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize { get => _colliderSize_Element.Data; set => _colliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderSize_Element = new();
public global::FrooxEngine.PBS_RimMetallic _shellMaterial { get => _shellMaterial_Element.Data; set => _shellMaterial_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _shellMaterial_Element = new();
public global::FrooxEngine.PBS_RimMetallic _checkMaterial { get => _checkMaterial_Element.Data; set => _checkMaterial_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _checkMaterial_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsChecked", IsChecked_Element.Data.ToResoniteLinkField());
members.Add("IsEnabled", IsEnabled_Element.Data.ToResoniteLinkField());
members.Add("DriveField", DriveField_Element.Data.ToResoniteReference(context));
members.Add("AllowWriteBack", AllowWriteBack_Element.Data.ToResoniteLinkField());
members.Add("Size", Size_Element.Data.ToResoniteLinkField());
members.Add("BevelPercent", BevelPercent_Element.Data.ToResoniteLinkField());
members.Add("Color", Color_Element.Data.ToResoniteLinkField());
members.Add("_shellMesh", _shellMesh_Element.Data.ToResoniteReference(context));
members.Add("_checkMesh", _checkMesh_Element.Data.ToResoniteReference(context));
members.Add("_titleBar", _titleBar_Element.Data.ToResoniteReference(context));
members.Add("_shellSize", _shellSize_Element.Data.ToResoniteReference(context));
members.Add("_shellBevel", _shellBevel_Element.Data.ToResoniteReference(context));
members.Add("_checkSize", _checkSize_Element.Data.ToResoniteReference(context));
members.Add("_checkBevel", _checkBevel_Element.Data.ToResoniteReference(context));
members.Add("_colliderSize", _colliderSize_Element.Data.ToResoniteReference(context));
members.Add("_shellMaterial", _shellMaterial_Element.Data.ToResoniteReference(context));
members.Add("_checkMaterial", _checkMaterial_Element.Data.ToResoniteReference(context));
}

}
}
