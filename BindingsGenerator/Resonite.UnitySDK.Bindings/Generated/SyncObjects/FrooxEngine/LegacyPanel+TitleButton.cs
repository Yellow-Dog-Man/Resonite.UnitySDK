
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyPanel+TitleButton
// Generated on: středa 25. února 2026 16:14:40
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
    public UnityEngine.ColorX ItemColor;
public global::System.Boolean Enabled;
public global::FrooxEngine.PBS_RimMetallic _material;
public global::FrooxEngine.UnlitMaterial _iconMaterial;
public global::FrooxEngine.StaticTexture2D _iconTexture;
public global::FrooxEngine.Slot _itemRoot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _position;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize;
public global::FrooxEngine.IField<UnityEngine.Vector2> _iconSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> _iconOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemColor", ItemColor.ToResoniteLinkField());
members.Add("Enabled", Enabled.ToResoniteLinkField());
members.Add("_material", _material.ToResoniteReference(context));
members.Add("_iconMaterial", _iconMaterial.ToResoniteReference(context));
members.Add("_iconTexture", _iconTexture.ToResoniteReference(context));
members.Add("_itemRoot", _itemRoot.ToResoniteReference(context));
members.Add("_position", _position.ToResoniteReference(context));
members.Add("_colliderSize", _colliderSize.ToResoniteReference(context));
members.Add("_iconSize", _iconSize.ToResoniteReference(context));
members.Add("_iconOffset", _iconOffset.ToResoniteReference(context));
}

}
            }
}
