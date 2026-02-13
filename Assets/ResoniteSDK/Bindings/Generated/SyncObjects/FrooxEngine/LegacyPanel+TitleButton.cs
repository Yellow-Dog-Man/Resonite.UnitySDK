
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyPanel+TitleButton
// Generated on: pátek 13. února 2026 5:52:33
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ItemColor", ItemColor.ToResoniteLinkField());
members.Add("Enabled", Enabled.ToResoniteLinkField());
members.Add("_material", new ResoniteLink.Reference() { });
members.Add("_iconMaterial", new ResoniteLink.Reference() { });
members.Add("_iconTexture", new ResoniteLink.Reference() { });
members.Add("_itemRoot", new ResoniteLink.Reference() { });
members.Add("_position", new ResoniteLink.Reference() { });
members.Add("_colliderSize", new ResoniteLink.Reference() { });
members.Add("_iconSize", new ResoniteLink.Reference() { });
members.Add("_iconOffset", new ResoniteLink.Reference() { });
}

}
            }
}
