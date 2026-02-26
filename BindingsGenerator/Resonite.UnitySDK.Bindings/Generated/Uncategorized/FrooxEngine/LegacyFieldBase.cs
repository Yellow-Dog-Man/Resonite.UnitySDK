
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyFieldBase
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyFieldBase")]
public abstract partial class LegacyFieldBase : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.ITouchable

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
public global::FrooxEngine.Slot _textSlot { get => _textSlot_Element.Data; set => _textSlot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _textSlot_Element = new();
public global::FrooxEngine.TextRenderer _textRenderer { get => _textRenderer_Element.Data; set => _textRenderer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _textRenderer_Element = new();
public global::FrooxEngine.TextEditor _textEditor { get => _textEditor_Element.Data; set => _textEditor_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextEditor>, global::FrooxEngine.TextEditor> _textEditor_Element = new();
public global::FrooxEngine.PBS_RimMetallic _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _material_Element = new();
public global::FrooxEngine.BevelStripeMesh _mesh { get => _mesh_Element.Data; set => _mesh_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _mesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _textBounds { get => _textBounds_Element.Data; set => _textBounds_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _textBounds_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize { get => _colliderSize_Element.Data; set => _colliderSize_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderSize_Element = new();
public global::FrooxEngine.BevelStripeMesh _meshLeft { get => _meshLeft_Element.Data; set => _meshLeft_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _meshLeft_Element = new();
public global::FrooxEngine.BevelStripeMesh _meshRight { get => _meshRight_Element.Data; set => _meshRight_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _meshRight_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _textLeftBounds { get => _textLeftBounds_Element.Data; set => _textLeftBounds_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _textLeftBounds_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _textRightBounds { get => _textRightBounds_Element.Data; set => _textRightBounds_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _textRightBounds_Element = new();
public global::FrooxEngine.TextRenderer _leftTextRenderer { get => _leftTextRenderer_Element.Data; set => _leftTextRenderer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _leftTextRenderer_Element = new();
public global::FrooxEngine.TextRenderer _rightTextRenderer { get => _rightTextRenderer_Element.Data; set => _rightTextRenderer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _rightTextRenderer_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderLeftSize { get => _colliderLeftSize_Element.Data; set => _colliderLeftSize_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderLeftSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderRightSize { get => _colliderRightSize_Element.Data; set => _colliderRightSize_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderRightSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftOffset { get => _leftOffset_Element.Data; set => _leftOffset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightOffset { get => _rightOffset_Element.Data; set => _rightOffset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftTextPosition { get => _leftTextPosition_Element.Data; set => _leftTextPosition_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _leftTextPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightTextPosition { get => _rightTextPosition_Element.Data; set => _rightTextPosition_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rightTextPosition_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("Width", Width_Element.ToLinkField(context));
members.Add("Height", Height_Element.ToLinkField(context));
members.Add("Thickness", Thickness_Element.ToLinkField(context));
members.Add("Slant", Slant_Element.ToLinkField(context));
members.Add("_textSlot", _textSlot_Element.ToLinkReference(context));
members.Add("_textRenderer", _textRenderer_Element.ToLinkReference(context));
members.Add("_textEditor", _textEditor_Element.ToLinkReference(context));
members.Add("_material", _material_Element.ToLinkReference(context));
members.Add("_mesh", _mesh_Element.ToLinkReference(context));
members.Add("_textBounds", _textBounds_Element.ToLinkReference(context));
members.Add("_colliderSize", _colliderSize_Element.ToLinkReference(context));
members.Add("_meshLeft", _meshLeft_Element.ToLinkReference(context));
members.Add("_meshRight", _meshRight_Element.ToLinkReference(context));
members.Add("_textLeftBounds", _textLeftBounds_Element.ToLinkReference(context));
members.Add("_textRightBounds", _textRightBounds_Element.ToLinkReference(context));
members.Add("_leftTextRenderer", _leftTextRenderer_Element.ToLinkReference(context));
members.Add("_rightTextRenderer", _rightTextRenderer_Element.ToLinkReference(context));
members.Add("_colliderLeftSize", _colliderLeftSize_Element.ToLinkReference(context));
members.Add("_colliderRightSize", _colliderRightSize_Element.ToLinkReference(context));
members.Add("_leftOffset", _leftOffset_Element.ToLinkReference(context));
members.Add("_rightOffset", _rightOffset_Element.ToLinkReference(context));
members.Add("_leftTextPosition", _leftTextPosition_Element.ToLinkReference(context));
members.Add("_rightTextPosition", _rightTextPosition_Element.ToLinkReference(context));
}

}
}
