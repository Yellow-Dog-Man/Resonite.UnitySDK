
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyFieldBase
// Generated on: pátek 13. února 2026 5:52:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyFieldBase")]
public abstract partial class LegacyFieldBase : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.ITouchable

{
    public UnityEngine.ColorX Color;
public global::System.Single Width;
public global::System.Single Height;
public global::System.Single Thickness;
public global::System.Single Slant;
public global::FrooxEngine.Slot _textSlot;
public global::FrooxEngine.TextRenderer _textRenderer;
public global::FrooxEngine.TextEditor _textEditor;
public global::FrooxEngine.PBS_RimMetallic _material;
public global::FrooxEngine.BevelStripeMesh _mesh;
public global::FrooxEngine.IField<UnityEngine.Vector2> _textBounds;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize;
public global::FrooxEngine.BevelStripeMesh _meshLeft;
public global::FrooxEngine.BevelStripeMesh _meshRight;
public global::FrooxEngine.IField<UnityEngine.Vector2> _textLeftBounds;
public global::FrooxEngine.IField<UnityEngine.Vector2> _textRightBounds;
public global::FrooxEngine.TextRenderer _leftTextRenderer;
public global::FrooxEngine.TextRenderer _rightTextRenderer;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderLeftSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderRightSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _leftTextPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rightTextPosition;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("Slant", Slant.ToResoniteLinkField());
members.Add("_textSlot", new ResoniteLink.Reference() { });
members.Add("_textRenderer", new ResoniteLink.Reference() { });
members.Add("_textEditor", new ResoniteLink.Reference() { });
members.Add("_material", new ResoniteLink.Reference() { });
members.Add("_mesh", new ResoniteLink.Reference() { });
members.Add("_textBounds", new ResoniteLink.Reference() { });
members.Add("_colliderSize", new ResoniteLink.Reference() { });
members.Add("_meshLeft", new ResoniteLink.Reference() { });
members.Add("_meshRight", new ResoniteLink.Reference() { });
members.Add("_textLeftBounds", new ResoniteLink.Reference() { });
members.Add("_textRightBounds", new ResoniteLink.Reference() { });
members.Add("_leftTextRenderer", new ResoniteLink.Reference() { });
members.Add("_rightTextRenderer", new ResoniteLink.Reference() { });
members.Add("_colliderLeftSize", new ResoniteLink.Reference() { });
members.Add("_colliderRightSize", new ResoniteLink.Reference() { });
members.Add("_leftOffset", new ResoniteLink.Reference() { });
members.Add("_rightOffset", new ResoniteLink.Reference() { });
members.Add("_leftTextPosition", new ResoniteLink.Reference() { });
members.Add("_rightTextPosition", new ResoniteLink.Reference() { });
}

}
}
