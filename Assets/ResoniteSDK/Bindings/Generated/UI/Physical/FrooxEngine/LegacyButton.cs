
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyButton
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("Slant", Slant.ToResoniteLinkField());
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("IsPressed", IsPressed.ToResoniteLinkField());
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch.ToResoniteLinkField());
members.Add("_textSlot", new ResoniteLink.Reference() { });
members.Add("_textRenderer", new ResoniteLink.Reference() { });
members.Add("_buttonPosition", new ResoniteLink.Reference() { });
members.Add("_colliderSize", new ResoniteLink.Reference() { });
members.Add("_colliderOffset", new ResoniteLink.Reference() { });
members.Add("_textPosition", new ResoniteLink.Reference() { });
members.Add("_textBounds", new ResoniteLink.Reference() { });
members.Add("_holderMesh", new ResoniteLink.Reference() { });
members.Add("_buttonMesh", new ResoniteLink.Reference() { });
members.Add("_holderMaterial", new ResoniteLink.Reference() { });
members.Add("_buttonMaterial", new ResoniteLink.Reference() { });
members.Add("_pressDepth", _pressDepth.ToResoniteLinkField());
members.Add("_flashIndex", _flashIndex.ToResoniteLinkField());
}

}
}
