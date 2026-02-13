
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyHorizontalChoiceBar+Item
// Generated on: pátek 13. února 2026 23:23:11
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public UnityEngine.ColorX OverrideColor;
public global::System.Boolean Highlight;
public global::FrooxEngine.Slot _slot;
public global::FrooxEngine.TextRenderer _text;
public global::FrooxEngine.IField<UnityEngine.Vector3> _position;
public global::FrooxEngine.IField<UnityEngine.Vector3> _textPosition;
public global::FrooxEngine.IField<UnityEngine.Vector2> _textBounds;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderOffset;
public global::FrooxEngine.BevelStripeMesh _mesh;
public global::FrooxEngine.PBS_RimMetallic _material;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OverrideColor", OverrideColor.ToResoniteLinkField());
members.Add("Highlight", Highlight.ToResoniteLinkField());
members.Add("_slot", new ResoniteLink.Reference() { });
members.Add("_text", new ResoniteLink.Reference() { });
members.Add("_position", new ResoniteLink.Reference() { });
members.Add("_textPosition", new ResoniteLink.Reference() { });
members.Add("_textBounds", new ResoniteLink.Reference() { });
members.Add("_colliderSize", new ResoniteLink.Reference() { });
members.Add("_colliderOffset", new ResoniteLink.Reference() { });
members.Add("_mesh", new ResoniteLink.Reference() { });
members.Add("_material", new ResoniteLink.Reference() { });
}

}
            }
}
