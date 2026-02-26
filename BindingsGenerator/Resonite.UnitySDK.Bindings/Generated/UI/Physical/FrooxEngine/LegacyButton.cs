
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyButton
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyButton")]
public partial class LegacyButton : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.IButton, global::FrooxEngine.ITouchable

{
    public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::System.Single Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Width_Element = new();
public global::System.Single Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Height_Element = new();
public global::System.Single Thickness { get => Thickness_Element.Data; set => Thickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Thickness_Element = new();
public global::System.Single Slant { get => Slant_Element.Data; set => Slant_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Slant_Element = new();
public global::System.Boolean IsEnabled { get => IsEnabled_Element.Data; set => IsEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsEnabled_Element = new();
public global::System.Boolean IsPressed { get => IsPressed_Element.Data; set => IsPressed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsPressed_Element = new();
public global::System.Boolean AcceptOutOfSightTouch { get => AcceptOutOfSightTouch_Element.Data; set => AcceptOutOfSightTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptOutOfSightTouch_Element = new();
public global::FrooxEngine.Slot _textSlot { get => _textSlot_Element.Data; set => _textSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _textSlot_Element = new();
public global::FrooxEngine.TextRenderer _textRenderer { get => _textRenderer_Element.Data; set => _textRenderer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _textRenderer_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _buttonPosition { get => _buttonPosition_Element.Data; set => _buttonPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _buttonPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize { get => _colliderSize_Element.Data; set => _colliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderOffset { get => _colliderOffset_Element.Data; set => _colliderOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _textPosition { get => _textPosition_Element.Data; set => _textPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _textPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _textBounds { get => _textBounds_Element.Data; set => _textBounds_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _textBounds_Element = new();
public global::FrooxEngine.BevelStripeMesh _holderMesh { get => _holderMesh_Element.Data; set => _holderMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _holderMesh_Element = new();
public global::FrooxEngine.BevelStripeMesh _buttonMesh { get => _buttonMesh_Element.Data; set => _buttonMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _buttonMesh_Element = new();
public global::FrooxEngine.PBS_RimMetallic _holderMaterial { get => _holderMaterial_Element.Data; set => _holderMaterial_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _holderMaterial_Element = new();
public global::FrooxEngine.PBS_RimMetallic _buttonMaterial { get => _buttonMaterial_Element.Data; set => _buttonMaterial_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _buttonMaterial_Element = new();
public global::System.Single _pressDepth { get => _pressDepth_Element.Data; set => _pressDepth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _pressDepth_Element = new();
public global::System.Int32 _flashIndex { get => _flashIndex_Element.Data; set => _flashIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _flashIndex_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color_Element.Data.ToResoniteLinkField());
members.Add("Width", Width_Element.Data.ToResoniteLinkField());
members.Add("Height", Height_Element.Data.ToResoniteLinkField());
members.Add("Thickness", Thickness_Element.Data.ToResoniteLinkField());
members.Add("Slant", Slant_Element.Data.ToResoniteLinkField());
members.Add("IsEnabled", IsEnabled_Element.Data.ToResoniteLinkField());
members.Add("IsPressed", IsPressed_Element.Data.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch_Element.Data.ToResoniteLinkField());
members.Add("_textSlot", _textSlot_Element.Data.ToResoniteReference(context));
members.Add("_textRenderer", _textRenderer_Element.Data.ToResoniteReference(context));
members.Add("_buttonPosition", _buttonPosition_Element.Data.ToResoniteReference(context));
members.Add("_colliderSize", _colliderSize_Element.Data.ToResoniteReference(context));
members.Add("_colliderOffset", _colliderOffset_Element.Data.ToResoniteReference(context));
members.Add("_textPosition", _textPosition_Element.Data.ToResoniteReference(context));
members.Add("_textBounds", _textBounds_Element.Data.ToResoniteReference(context));
members.Add("_holderMesh", _holderMesh_Element.Data.ToResoniteReference(context));
members.Add("_buttonMesh", _buttonMesh_Element.Data.ToResoniteReference(context));
members.Add("_holderMaterial", _holderMaterial_Element.Data.ToResoniteReference(context));
members.Add("_buttonMaterial", _buttonMaterial_Element.Data.ToResoniteReference(context));
members.Add("_pressDepth", _pressDepth_Element.Data.ToResoniteLinkField());
members.Add("_flashIndex", _flashIndex_Element.Data.ToResoniteLinkField());
}

}
}
