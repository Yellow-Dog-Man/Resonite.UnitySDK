
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyHorizontalChoiceBar+Item
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
    public partial class LegacyHorizontalChoiceBar
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyHorizontalChoiceBar+Item")]
public partial class Item : global::FrooxEngine.SyncObject

{
    public UnityEngine.ColorX OverrideColor { get => OverrideColor_Element.Data; set => OverrideColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OverrideColor_Element = new();
public global::System.Boolean Highlight { get => Highlight_Element.Data; set => Highlight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Highlight_Element = new();
public global::FrooxEngine.Slot _slot { get => _slot_Element.Data; set => _slot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _slot_Element = new();
public global::FrooxEngine.TextRenderer _text { get => _text_Element.Data; set => _text_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _text_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _position { get => _position_Element.Data; set => _position_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _textPosition { get => _textPosition_Element.Data; set => _textPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _textPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _textBounds { get => _textBounds_Element.Data; set => _textBounds_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _textBounds_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize { get => _colliderSize_Element.Data; set => _colliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderOffset { get => _colliderOffset_Element.Data; set => _colliderOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderOffset_Element = new();
public global::FrooxEngine.BevelStripeMesh _mesh { get => _mesh_Element.Data; set => _mesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _mesh_Element = new();
public global::FrooxEngine.PBS_RimMetallic _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _material_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OverrideColor", OverrideColor_Element.ToLinkField(context));
members.Add("Highlight", Highlight_Element.ToLinkField(context));
members.Add("_slot", _slot_Element.ToLinkReference(context));
members.Add("_text", _text_Element.ToLinkReference(context));
members.Add("_position", _position_Element.ToLinkReference(context));
members.Add("_textPosition", _textPosition_Element.ToLinkReference(context));
members.Add("_textBounds", _textBounds_Element.ToLinkReference(context));
members.Add("_colliderSize", _colliderSize_Element.ToLinkReference(context));
members.Add("_colliderOffset", _colliderOffset_Element.ToLinkReference(context));
members.Add("_mesh", _mesh_Element.ToLinkReference(context));
members.Add("_material", _material_Element.ToLinkReference(context));
}

}
            }
}
