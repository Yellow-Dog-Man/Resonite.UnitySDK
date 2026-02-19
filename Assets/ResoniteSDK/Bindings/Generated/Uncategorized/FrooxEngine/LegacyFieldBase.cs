
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyFieldBase
// Generated on: čtvrtek 19. února 2026 8:00:25
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("Slant", Slant.ToResoniteLinkField());
members.Add("_textSlot", _textSlot.ToResoniteReference(context));
members.Add("_textRenderer", _textRenderer.ToResoniteReference(context));
members.Add("_textEditor", _textEditor.ToResoniteReference(context));
members.Add("_material", _material.ToResoniteReference(context));
members.Add("_mesh", _mesh.ToResoniteReference(context));
members.Add("_textBounds", _textBounds.ToResoniteReference(context));
members.Add("_colliderSize", _colliderSize.ToResoniteReference(context));
members.Add("_meshLeft", _meshLeft.ToResoniteReference(context));
members.Add("_meshRight", _meshRight.ToResoniteReference(context));
members.Add("_textLeftBounds", _textLeftBounds.ToResoniteReference(context));
members.Add("_textRightBounds", _textRightBounds.ToResoniteReference(context));
members.Add("_leftTextRenderer", _leftTextRenderer.ToResoniteReference(context));
members.Add("_rightTextRenderer", _rightTextRenderer.ToResoniteReference(context));
members.Add("_colliderLeftSize", _colliderLeftSize.ToResoniteReference(context));
members.Add("_colliderRightSize", _colliderRightSize.ToResoniteReference(context));
members.Add("_leftOffset", _leftOffset.ToResoniteReference(context));
members.Add("_rightOffset", _rightOffset.ToResoniteReference(context));
members.Add("_leftTextPosition", _leftTextPosition.ToResoniteReference(context));
members.Add("_rightTextPosition", _rightTextPosition.ToResoniteReference(context));
}

}
}
