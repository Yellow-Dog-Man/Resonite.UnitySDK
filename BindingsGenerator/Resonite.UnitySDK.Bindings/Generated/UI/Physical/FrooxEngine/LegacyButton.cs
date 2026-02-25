
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyButton
// Generated on: středa 25. února 2026 16:14:33
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
    public UnityEngine.ColorX Color;
public global::System.Single Width;
public global::System.Single Height;
public global::System.Single Thickness;
public global::System.Single Slant;
public global::System.Boolean IsEnabled;
public global::System.Boolean IsPressed;
public global::System.Boolean AcceptOutOfSightTouch;
public global::FrooxEngine.Slot _textSlot;
public global::FrooxEngine.TextRenderer _textRenderer;
public global::FrooxEngine.IField<UnityEngine.Vector3> _buttonPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> _colliderOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _textPosition;
public global::FrooxEngine.IField<UnityEngine.Vector2> _textBounds;
public global::FrooxEngine.BevelStripeMesh _holderMesh;
public global::FrooxEngine.BevelStripeMesh _buttonMesh;
public global::FrooxEngine.PBS_RimMetallic _holderMaterial;
public global::FrooxEngine.PBS_RimMetallic _buttonMaterial;
public global::System.Single _pressDepth;
public global::System.Int32 _flashIndex;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("Slant", Slant.ToResoniteLinkField());
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("IsPressed", IsPressed.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch.ToResoniteLinkField());
members.Add("_textSlot", _textSlot.ToResoniteReference(context));
members.Add("_textRenderer", _textRenderer.ToResoniteReference(context));
members.Add("_buttonPosition", _buttonPosition.ToResoniteReference(context));
members.Add("_colliderSize", _colliderSize.ToResoniteReference(context));
members.Add("_colliderOffset", _colliderOffset.ToResoniteReference(context));
members.Add("_textPosition", _textPosition.ToResoniteReference(context));
members.Add("_textBounds", _textBounds.ToResoniteReference(context));
members.Add("_holderMesh", _holderMesh.ToResoniteReference(context));
members.Add("_buttonMesh", _buttonMesh.ToResoniteReference(context));
members.Add("_holderMaterial", _holderMaterial.ToResoniteReference(context));
members.Add("_buttonMaterial", _buttonMaterial.ToResoniteReference(context));
members.Add("_pressDepth", _pressDepth.ToResoniteLinkField());
members.Add("_flashIndex", _flashIndex.ToResoniteLinkField());
}

}
}
