
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyPanel+TitleButton
// Generated on: čtvrtek 26. února 2026 10:04:46
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
    public partial class LegacyPanel
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyPanel+TitleButton")]
public partial class TitleButton : global::FrooxEngine.SyncObject

{
    public UnityEngine.ColorX ItemColor { get => ItemColor_Element.Data; set => ItemColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> ItemColor_Element = new();
public global::System.Boolean Enabled { get => Enabled_Element.Data; set => Enabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Enabled_Element = new();
public global::FrooxEngine.PBS_RimMetallic _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _material_Element = new();
public global::FrooxEngine.UnlitMaterial _iconMaterial { get => _iconMaterial_Element.Data; set => _iconMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> _iconMaterial_Element = new();
public global::FrooxEngine.StaticTexture2D _iconTexture { get => _iconTexture_Element.Data; set => _iconTexture_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> _iconTexture_Element = new();
public global::FrooxEngine.Slot _itemRoot { get => _itemRoot_Element.Data; set => _itemRoot_Element.Data = value; }
public Field<global::FrooxEngine.CleanupRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _itemRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _position { get => _position_Element.Data; set => _position_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize { get => _colliderSize_Element.Data; set => _colliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _colliderSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _iconSize { get => _iconSize_Element.Data; set => _iconSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _iconSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _iconOffset { get => _iconOffset_Element.Data; set => _iconOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _iconOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemColor", ItemColor_Element.Data.ToResoniteLinkField());
members.Add("Enabled", Enabled_Element.Data.ToResoniteLinkField());
members.Add("_material", _material_Element.Data.ToResoniteReference(context));
members.Add("_iconMaterial", _iconMaterial_Element.Data.ToResoniteReference(context));
members.Add("_iconTexture", _iconTexture_Element.Data.ToResoniteReference(context));
members.Add("_itemRoot", _itemRoot_Element.Data.ToResoniteReference(context));
members.Add("_position", _position_Element.Data.ToResoniteReference(context));
members.Add("_colliderSize", _colliderSize_Element.Data.ToResoniteReference(context));
members.Add("_iconSize", _iconSize_Element.Data.ToResoniteReference(context));
members.Add("_iconOffset", _iconOffset_Element.Data.ToResoniteReference(context));
}

}
            }
}
