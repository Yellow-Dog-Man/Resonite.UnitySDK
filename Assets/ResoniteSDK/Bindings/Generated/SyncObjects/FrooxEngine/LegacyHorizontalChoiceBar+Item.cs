
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyHorizontalChoiceBar+Item
// Generated on: sobota 14. února 2026 8:58:40
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OverrideColor", OverrideColor.ToResoniteLinkField());
members.Add("Highlight", Highlight.ToResoniteLinkField());
members.Add("_slot", _slot.ToResoniteReference(context));
members.Add("_text", _text.ToResoniteReference(context));
members.Add("_position", _position.ToResoniteReference(context));
members.Add("_textPosition", _textPosition.ToResoniteReference(context));
members.Add("_textBounds", _textBounds.ToResoniteReference(context));
members.Add("_colliderSize", _colliderSize.ToResoniteReference(context));
members.Add("_colliderOffset", _colliderOffset.ToResoniteReference(context));
members.Add("_mesh", _mesh.ToResoniteReference(context));
members.Add("_material", _material.ToResoniteReference(context));
}

}
            }
}
