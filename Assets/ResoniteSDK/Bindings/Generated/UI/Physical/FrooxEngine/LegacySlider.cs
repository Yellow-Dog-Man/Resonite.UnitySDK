
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySlider
// Generated on: pátek 13. února 2026 5:52:27
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsEnabledField", IsEnabledField.ToResoniteLinkField());
members.Add("DriveField", new ResoniteLink.Reference() { });
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
members.Add("_trackMesh", new ResoniteLink.Reference() { });
members.Add("_leftMesh", new ResoniteLink.Reference() { });
members.Add("_rightMesh", new ResoniteLink.Reference() { });
members.Add("_cursorMesh", new ResoniteLink.Reference() { });
members.Add("_trackMaterial", new ResoniteLink.Reference() { });
members.Add("_leftMaterial", new ResoniteLink.Reference() { });
members.Add("_rightMaterial", new ResoniteLink.Reference() { });
members.Add("_cursorMaterial", new ResoniteLink.Reference() { });
members.Add("_leftPosition", new ResoniteLink.Reference() { });
members.Add("_rightPosition", new ResoniteLink.Reference() { });
members.Add("_cursorPosition", new ResoniteLink.Reference() { });
members.Add("_leftColliderSize", new ResoniteLink.Reference() { });
members.Add("_rightColliderSize", new ResoniteLink.Reference() { });
members.Add("_trackColliderSize", new ResoniteLink.Reference() { });
members.Add("_cursorColliderSize", new ResoniteLink.Reference() { });
}

}
}
