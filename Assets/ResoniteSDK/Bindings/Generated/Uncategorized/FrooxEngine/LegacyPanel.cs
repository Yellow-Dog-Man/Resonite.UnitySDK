
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyPanel
// Generated on: čtvrtek 19. února 2026 8:00:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyPanel")]
public partial class LegacyPanel : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.IObjectRoot, global::FrooxEngine.IUIInterface

{
    public global::System.Boolean ShowHeader;
public global::System.Boolean ShowHandle;
public global::System.Single Padding;
public global::System.Single ZPadding;
public global::System.Single Thickness;
public System.Collections.Generic.List<global::FrooxEngine.IBounded> WhiteList;
public System.Collections.Generic.List<global::FrooxEngine.IBounded> BlackList;
public UnityEngine.ColorX Color;
public global::FrooxEngine.PBS_RimMetallic _material;
public global::FrooxEngine.BevelPlaneMesh _panelMesh;
public global::FrooxEngine.IField<UnityEngine.Vector3> _panelPos;
public global::FrooxEngine.IField<global::System.Boolean> _handleActive;
public global::FrooxEngine.IField<global::System.Boolean> _headerActive;
public global::FrooxEngine.BevelStripeMesh _handleMesh;
public global::FrooxEngine.IField<UnityEngine.Vector3> _handlePos;
public global::FrooxEngine.IField<UnityEngine.Vector3> _handleColliderSize;
public global::FrooxEngine.BevelStripeMesh _headerTitleMesh;
public global::FrooxEngine.BevelStripeMesh _headerButtonMesh;
public global::FrooxEngine.IField<UnityEngine.Vector3> _headerCollider;
public global::FrooxEngine.IField<UnityEngine.Vector3> _headerPos;
public global::FrooxEngine.IField<UnityEngine.Vector3> _headerTitlePos;
public global::System.String _title;
public global::FrooxEngine.TextRenderer _titleText;
public global::System.Boolean _indicatePrivate;
public global::FrooxEngine.IField<UnityEngine.Vector3> _titlePos;
public global::FrooxEngine.IField<UnityEngine.Vector2> _titleBounds;
public global::FrooxEngine.Slot _contentSlot;
public global::FrooxEngine.Slot _headerRoot;
public global::FrooxEngine.Slot _handleAnchorPoint;
public global::FrooxEngine.IField<UnityEngine.Vector3> _handleAnchorPointPosition;
public global::FrooxEngine.UserRef _userspaceOwner;
public System.Collections.Generic.List<global::FrooxEngine.LegacyPanel.TitleButton> _titleButtons;
public global::FrooxEngine.LegacyPanel.TitleButton _highlightedButton;
public global::FrooxEngine.LegacyPanel.TitleButton _pinButton;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ShowHeader", ShowHeader.ToResoniteLinkField());
members.Add("ShowHandle", ShowHandle.ToResoniteLinkField());
members.Add("Padding", Padding.ToResoniteLinkField());
members.Add("ZPadding", ZPadding.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("WhiteList", new ResoniteLink.SyncList()
{
    Elements = WhiteList.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("BlackList", new ResoniteLink.SyncList()
{
    Elements = BlackList.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("Color", Color.ToResoniteLinkField());
members.Add("_material", _material.ToResoniteReference(context));
members.Add("_panelMesh", _panelMesh.ToResoniteReference(context));
members.Add("_panelPos", _panelPos.ToResoniteReference(context));
members.Add("_handleActive", _handleActive.ToResoniteReference(context));
members.Add("_headerActive", _headerActive.ToResoniteReference(context));
members.Add("_handleMesh", _handleMesh.ToResoniteReference(context));
members.Add("_handlePos", _handlePos.ToResoniteReference(context));
members.Add("_handleColliderSize", _handleColliderSize.ToResoniteReference(context));
members.Add("_headerTitleMesh", _headerTitleMesh.ToResoniteReference(context));
members.Add("_headerButtonMesh", _headerButtonMesh.ToResoniteReference(context));
members.Add("_headerCollider", _headerCollider.ToResoniteReference(context));
members.Add("_headerPos", _headerPos.ToResoniteReference(context));
members.Add("_headerTitlePos", _headerTitlePos.ToResoniteReference(context));
members.Add("_title", _title.ToResoniteLinkField());
members.Add("_titleText", _titleText.ToResoniteReference(context));
members.Add("_indicatePrivate", _indicatePrivate.ToResoniteLinkField());
members.Add("_titlePos", _titlePos.ToResoniteReference(context));
members.Add("_titleBounds", _titleBounds.ToResoniteReference(context));
members.Add("_contentSlot", _contentSlot.ToResoniteReference(context));
members.Add("_headerRoot", _headerRoot.ToResoniteReference(context));
members.Add("_handleAnchorPoint", _handleAnchorPoint.ToResoniteReference(context));
members.Add("_handleAnchorPointPosition", _handleAnchorPointPosition.ToResoniteReference(context));
members.Add("_userspaceOwner", new ResoniteLink.SyncObject() { Members = _userspaceOwner.CollectMembers(context) });
members.Add("_titleButtons", new ResoniteLink.SyncList()
{
    Elements = _titleButtons.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("_highlightedButton", _highlightedButton.ToResoniteReference(context));
members.Add("_pinButton", _pinButton.ToResoniteReference(context));
}

}
}
