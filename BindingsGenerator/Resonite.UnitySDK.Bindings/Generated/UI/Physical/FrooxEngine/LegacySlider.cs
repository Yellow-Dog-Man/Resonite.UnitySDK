
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySlider
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySlider")]
public partial class LegacySlider : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.ISlider, global::FrooxEngine.ILegacyUIElement, global::FrooxEngine.ITouchable

{
    public global::System.Boolean IsEnabledField;
public global::FrooxEngine.IField<global::System.Single> DriveField;
public global::System.Boolean AllowWriteBack;
public global::System.Boolean CreateUndoStep;
public global::System.Single Value;
public global::System.Single Min;
public global::System.Single Max;
public global::System.Single Increment;
public global::System.Boolean IntegerOnly;
public UnityEngine.ColorX ColorField;
public global::System.Boolean SymmetricalField;
public global::System.Single WidthField;
public global::System.Single HeightField;
public global::System.Single CursorRatioField;
public global::System.Single ThicknessField;
public global::System.Single SlantField;
public global::System.Single SpacingRatioField;
public global::System.Single TrackRatioField;
public global::System.Single ButtonRatioField;
public global::FrooxEngine.MultiBevelStripeMesh _trackMesh;
public global::FrooxEngine.BevelStripeMesh _leftMesh;
public global::FrooxEngine.BevelStripeMesh _rightMesh;
public global::FrooxEngine.BevelStripeMesh _cursorMesh;
public global::FrooxEngine.PBS_RimMetallic _trackMaterial;
public global::FrooxEngine.PBS_RimMetallic _leftMaterial;
public global::FrooxEngine.PBS_RimMetallic _rightMaterial;
public global::FrooxEngine.PBS_RimMetallic _cursorMaterial;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _cursorPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftColliderSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightColliderSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> _trackColliderSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> _cursorColliderSize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsEnabledField", IsEnabledField.ToResoniteLinkField());
members.Add("DriveField", DriveField.ToResoniteReference(context));
members.Add("AllowWriteBack", AllowWriteBack.ToResoniteLinkField());
members.Add("CreateUndoStep", CreateUndoStep.ToResoniteLinkField());
members.Add("Value", Value.ToResoniteLinkField());
members.Add("Min", Min.ToResoniteLinkField());
members.Add("Max", Max.ToResoniteLinkField());
members.Add("Increment", Increment.ToResoniteLinkField());
members.Add("IntegerOnly", IntegerOnly.ToResoniteLinkField());
members.Add("ColorField", ColorField.ToResoniteLinkField());
members.Add("SymmetricalField", SymmetricalField.ToResoniteLinkField());
members.Add("WidthField", WidthField.ToResoniteLinkField());
members.Add("HeightField", HeightField.ToResoniteLinkField());
members.Add("CursorRatioField", CursorRatioField.ToResoniteLinkField());
members.Add("ThicknessField", ThicknessField.ToResoniteLinkField());
members.Add("SlantField", SlantField.ToResoniteLinkField());
members.Add("SpacingRatioField", SpacingRatioField.ToResoniteLinkField());
members.Add("TrackRatioField", TrackRatioField.ToResoniteLinkField());
members.Add("ButtonRatioField", ButtonRatioField.ToResoniteLinkField());
members.Add("_trackMesh", _trackMesh.ToResoniteReference(context));
members.Add("_leftMesh", _leftMesh.ToResoniteReference(context));
members.Add("_rightMesh", _rightMesh.ToResoniteReference(context));
members.Add("_cursorMesh", _cursorMesh.ToResoniteReference(context));
members.Add("_trackMaterial", _trackMaterial.ToResoniteReference(context));
members.Add("_leftMaterial", _leftMaterial.ToResoniteReference(context));
members.Add("_rightMaterial", _rightMaterial.ToResoniteReference(context));
members.Add("_cursorMaterial", _cursorMaterial.ToResoniteReference(context));
members.Add("_leftPosition", _leftPosition.ToResoniteReference(context));
members.Add("_rightPosition", _rightPosition.ToResoniteReference(context));
members.Add("_cursorPosition", _cursorPosition.ToResoniteReference(context));
members.Add("_leftColliderSize", _leftColliderSize.ToResoniteReference(context));
members.Add("_rightColliderSize", _rightColliderSize.ToResoniteReference(context));
members.Add("_trackColliderSize", _trackColliderSize.ToResoniteReference(context));
members.Add("_cursorColliderSize", _cursorColliderSize.ToResoniteReference(context));
}

}
}
