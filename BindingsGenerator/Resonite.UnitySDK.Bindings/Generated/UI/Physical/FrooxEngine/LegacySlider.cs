
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySlider
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySlider")]
public partial class LegacySlider : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.ISlider, global::FrooxEngine.ILegacyUIElement, global::FrooxEngine.ITouchable

{
    public global::System.Boolean IsEnabledField { get => IsEnabledField_Element.Data; set => IsEnabledField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsEnabledField_Element = new();
public global::FrooxEngine.IField<global::System.Single> DriveField { get => DriveField_Element.Data; set => DriveField_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> DriveField_Element = new();
public global::System.Boolean AllowWriteBack { get => AllowWriteBack_Element.Data; set => AllowWriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowWriteBack_Element = new();
public global::System.Boolean CreateUndoStep { get => CreateUndoStep_Element.Data; set => CreateUndoStep_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CreateUndoStep_Element = new();
public global::System.Single Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Value_Element = new();
public global::System.Single Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Min_Element = new();
public global::System.Single Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Max_Element = new();
public global::System.Single Increment { get => Increment_Element.Data; set => Increment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Increment_Element = new();
public global::System.Boolean IntegerOnly { get => IntegerOnly_Element.Data; set => IntegerOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IntegerOnly_Element = new();
public UnityEngine.ColorX ColorField { get => ColorField_Element.Data; set => ColorField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> ColorField_Element = new();
public global::System.Boolean SymmetricalField { get => SymmetricalField_Element.Data; set => SymmetricalField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SymmetricalField_Element = new();
public global::System.Single WidthField { get => WidthField_Element.Data; set => WidthField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> WidthField_Element = new();
public global::System.Single HeightField { get => HeightField_Element.Data; set => HeightField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeightField_Element = new();
public global::System.Single CursorRatioField { get => CursorRatioField_Element.Data; set => CursorRatioField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CursorRatioField_Element = new();
public global::System.Single ThicknessField { get => ThicknessField_Element.Data; set => ThicknessField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ThicknessField_Element = new();
public global::System.Single SlantField { get => SlantField_Element.Data; set => SlantField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SlantField_Element = new();
public global::System.Single SpacingRatioField { get => SpacingRatioField_Element.Data; set => SpacingRatioField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpacingRatioField_Element = new();
public global::System.Single TrackRatioField { get => TrackRatioField_Element.Data; set => TrackRatioField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TrackRatioField_Element = new();
public global::System.Single ButtonRatioField { get => ButtonRatioField_Element.Data; set => ButtonRatioField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ButtonRatioField_Element = new();
public global::FrooxEngine.MultiBevelStripeMesh _trackMesh { get => _trackMesh_Element.Data; set => _trackMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.MultiBevelStripeMesh>, global::FrooxEngine.MultiBevelStripeMesh> _trackMesh_Element = new();
public global::FrooxEngine.BevelStripeMesh _leftMesh { get => _leftMesh_Element.Data; set => _leftMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _leftMesh_Element = new();
public global::FrooxEngine.BevelStripeMesh _rightMesh { get => _rightMesh_Element.Data; set => _rightMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _rightMesh_Element = new();
public global::FrooxEngine.BevelStripeMesh _cursorMesh { get => _cursorMesh_Element.Data; set => _cursorMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _cursorMesh_Element = new();
public global::FrooxEngine.PBS_RimMetallic _trackMaterial { get => _trackMaterial_Element.Data; set => _trackMaterial_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _trackMaterial_Element = new();
public global::FrooxEngine.PBS_RimMetallic _leftMaterial { get => _leftMaterial_Element.Data; set => _leftMaterial_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _leftMaterial_Element = new();
public global::FrooxEngine.PBS_RimMetallic _rightMaterial { get => _rightMaterial_Element.Data; set => _rightMaterial_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _rightMaterial_Element = new();
public global::FrooxEngine.PBS_RimMetallic _cursorMaterial { get => _cursorMaterial_Element.Data; set => _cursorMaterial_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _cursorMaterial_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftPosition { get => _leftPosition_Element.Data; set => _leftPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightPosition { get => _rightPosition_Element.Data; set => _rightPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _cursorPosition { get => _cursorPosition_Element.Data; set => _cursorPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _cursorPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftColliderSize { get => _leftColliderSize_Element.Data; set => _leftColliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftColliderSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightColliderSize { get => _rightColliderSize_Element.Data; set => _rightColliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightColliderSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _trackColliderSize { get => _trackColliderSize_Element.Data; set => _trackColliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _trackColliderSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _cursorColliderSize { get => _cursorColliderSize_Element.Data; set => _cursorColliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _cursorColliderSize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsEnabledField", IsEnabledField_Element.Data.ToResoniteLinkField());
members.Add("DriveField", DriveField_Element.Data.ToResoniteReference(context));
members.Add("AllowWriteBack", AllowWriteBack_Element.Data.ToResoniteLinkField());
members.Add("CreateUndoStep", CreateUndoStep_Element.Data.ToResoniteLinkField());
members.Add("Value", Value_Element.Data.ToResoniteLinkField());
members.Add("Min", Min_Element.Data.ToResoniteLinkField());
members.Add("Max", Max_Element.Data.ToResoniteLinkField());
members.Add("Increment", Increment_Element.Data.ToResoniteLinkField());
members.Add("IntegerOnly", IntegerOnly_Element.Data.ToResoniteLinkField());
members.Add("ColorField", ColorField_Element.Data.ToResoniteLinkField());
members.Add("SymmetricalField", SymmetricalField_Element.Data.ToResoniteLinkField());
members.Add("WidthField", WidthField_Element.Data.ToResoniteLinkField());
members.Add("HeightField", HeightField_Element.Data.ToResoniteLinkField());
members.Add("CursorRatioField", CursorRatioField_Element.Data.ToResoniteLinkField());
members.Add("ThicknessField", ThicknessField_Element.Data.ToResoniteLinkField());
members.Add("SlantField", SlantField_Element.Data.ToResoniteLinkField());
members.Add("SpacingRatioField", SpacingRatioField_Element.Data.ToResoniteLinkField());
members.Add("TrackRatioField", TrackRatioField_Element.Data.ToResoniteLinkField());
members.Add("ButtonRatioField", ButtonRatioField_Element.Data.ToResoniteLinkField());
members.Add("_trackMesh", _trackMesh_Element.Data.ToResoniteReference(context));
members.Add("_leftMesh", _leftMesh_Element.Data.ToResoniteReference(context));
members.Add("_rightMesh", _rightMesh_Element.Data.ToResoniteReference(context));
members.Add("_cursorMesh", _cursorMesh_Element.Data.ToResoniteReference(context));
members.Add("_trackMaterial", _trackMaterial_Element.Data.ToResoniteReference(context));
members.Add("_leftMaterial", _leftMaterial_Element.Data.ToResoniteReference(context));
members.Add("_rightMaterial", _rightMaterial_Element.Data.ToResoniteReference(context));
members.Add("_cursorMaterial", _cursorMaterial_Element.Data.ToResoniteReference(context));
members.Add("_leftPosition", _leftPosition_Element.Data.ToResoniteReference(context));
members.Add("_rightPosition", _rightPosition_Element.Data.ToResoniteReference(context));
members.Add("_cursorPosition", _cursorPosition_Element.Data.ToResoniteReference(context));
members.Add("_leftColliderSize", _leftColliderSize_Element.Data.ToResoniteReference(context));
members.Add("_rightColliderSize", _rightColliderSize_Element.Data.ToResoniteReference(context));
members.Add("_trackColliderSize", _trackColliderSize_Element.Data.ToResoniteReference(context));
members.Add("_cursorColliderSize", _cursorColliderSize_Element.Data.ToResoniteReference(context));
}

}
}
