
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyPanel
// Generated on: čtvrtek 26. února 2026 12:28:11
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyPanel")]
public partial class LegacyPanel : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.IObjectRoot, global::FrooxEngine.IUIInterface

{
    public global::System.Boolean ShowHeader { get => ShowHeader_Element.Data; set => ShowHeader_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowHeader_Element = new();
public global::System.Boolean ShowHandle { get => ShowHandle_Element.Data; set => ShowHandle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowHandle_Element = new();
public global::System.Single Padding { get => Padding_Element.Data; set => Padding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Padding_Element = new();
public global::System.Single ZPadding { get => ZPadding_Element.Data; set => ZPadding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ZPadding_Element = new();
public global::System.Single Thickness { get => Thickness_Element.Data; set => Thickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Thickness_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IBounded>, global::FrooxEngine.IBounded, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IBounded>, global::FrooxEngine.IBounded>> WhiteList = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IBounded>, global::FrooxEngine.IBounded, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IBounded>, global::FrooxEngine.IBounded>> BlackList = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::FrooxEngine.PBS_RimMetallic _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _material_Element = new();
public global::FrooxEngine.BevelPlaneMesh _panelMesh { get => _panelMesh_Element.Data; set => _panelMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelPlaneMesh>, global::FrooxEngine.BevelPlaneMesh> _panelMesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _panelPos { get => _panelPos_Element.Data; set => _panelPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _panelPos_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _handleActive { get => _handleActive_Element.Data; set => _handleActive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _handleActive_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _headerActive { get => _headerActive_Element.Data; set => _headerActive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _headerActive_Element = new();
public global::FrooxEngine.BevelStripeMesh _handleMesh { get => _handleMesh_Element.Data; set => _handleMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _handleMesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _handlePos { get => _handlePos_Element.Data; set => _handlePos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _handlePos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _handleColliderSize { get => _handleColliderSize_Element.Data; set => _handleColliderSize_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _handleColliderSize_Element = new();
public global::FrooxEngine.BevelStripeMesh _headerTitleMesh { get => _headerTitleMesh_Element.Data; set => _headerTitleMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _headerTitleMesh_Element = new();
public global::FrooxEngine.BevelStripeMesh _headerButtonMesh { get => _headerButtonMesh_Element.Data; set => _headerButtonMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.BevelStripeMesh>, global::FrooxEngine.BevelStripeMesh> _headerButtonMesh_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _headerCollider { get => _headerCollider_Element.Data; set => _headerCollider_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _headerCollider_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _headerPos { get => _headerPos_Element.Data; set => _headerPos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _headerPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _headerTitlePos { get => _headerTitlePos_Element.Data; set => _headerTitlePos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _headerTitlePos_Element = new();
public global::System.String _title { get => _title_Element.Data; set => _title_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _title_Element = new();
public global::FrooxEngine.TextRenderer _titleText { get => _titleText_Element.Data; set => _titleText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _titleText_Element = new();
public global::System.Boolean _indicatePrivate { get => _indicatePrivate_Element.Data; set => _indicatePrivate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _indicatePrivate_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _titlePos { get => _titlePos_Element.Data; set => _titlePos_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _titlePos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _titleBounds { get => _titleBounds_Element.Data; set => _titleBounds_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _titleBounds_Element = new();
public global::FrooxEngine.Slot _contentSlot { get => _contentSlot_Element.Data; set => _contentSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _contentSlot_Element = new();
public global::FrooxEngine.Slot _headerRoot { get => _headerRoot_Element.Data; set => _headerRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _headerRoot_Element = new();
public global::FrooxEngine.Slot _handleAnchorPoint { get => _handleAnchorPoint_Element.Data; set => _handleAnchorPoint_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _handleAnchorPoint_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _handleAnchorPointPosition { get => _handleAnchorPointPosition_Element.Data; set => _handleAnchorPointPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _handleAnchorPointPosition_Element = new();
public global::FrooxEngine.UserRef _userspaceOwner = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LegacyPanel.TitleButton>, global::FrooxEngine.LegacyPanel.TitleButton> _titleButtons = new();
public global::FrooxEngine.LegacyPanel.TitleButton _highlightedButton { get => _highlightedButton_Element.Data; set => _highlightedButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyPanel.TitleButton>, global::FrooxEngine.LegacyPanel.TitleButton> _highlightedButton_Element = new();
public global::FrooxEngine.LegacyPanel.TitleButton _pinButton { get => _pinButton_Element.Data; set => _pinButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyPanel.TitleButton>, global::FrooxEngine.LegacyPanel.TitleButton> _pinButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ShowHeader", ShowHeader_Element.ToLinkField(context));
members.Add("ShowHandle", ShowHandle_Element.ToLinkField(context));
members.Add("Padding", Padding_Element.ToLinkField(context));
members.Add("ZPadding", ZPadding_Element.ToLinkField(context));
members.Add("Thickness", Thickness_Element.ToLinkField(context));
members.Add("WhiteList", WhiteList.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("BlackList", BlackList.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("_material", _material_Element.ToLinkReference(context));
members.Add("_panelMesh", _panelMesh_Element.ToLinkReference(context));
members.Add("_panelPos", _panelPos_Element.ToLinkReference(context));
members.Add("_handleActive", _handleActive_Element.ToLinkReference(context));
members.Add("_headerActive", _headerActive_Element.ToLinkReference(context));
members.Add("_handleMesh", _handleMesh_Element.ToLinkReference(context));
members.Add("_handlePos", _handlePos_Element.ToLinkReference(context));
members.Add("_handleColliderSize", _handleColliderSize_Element.ToLinkReference(context));
members.Add("_headerTitleMesh", _headerTitleMesh_Element.ToLinkReference(context));
members.Add("_headerButtonMesh", _headerButtonMesh_Element.ToLinkReference(context));
members.Add("_headerCollider", _headerCollider_Element.ToLinkReference(context));
members.Add("_headerPos", _headerPos_Element.ToLinkReference(context));
members.Add("_headerTitlePos", _headerTitlePos_Element.ToLinkReference(context));
members.Add("_title", _title_Element.ToLinkField(context));
members.Add("_titleText", _titleText_Element.ToLinkReference(context));
members.Add("_indicatePrivate", _indicatePrivate_Element.ToLinkField(context));
members.Add("_titlePos", _titlePos_Element.ToLinkReference(context));
members.Add("_titleBounds", _titleBounds_Element.ToLinkReference(context));
members.Add("_contentSlot", _contentSlot_Element.ToLinkReference(context));
members.Add("_headerRoot", _headerRoot_Element.ToLinkReference(context));
members.Add("_handleAnchorPoint", _handleAnchorPoint_Element.ToLinkReference(context));
members.Add("_handleAnchorPointPosition", _handleAnchorPointPosition_Element.ToLinkReference(context));
members.Add("_userspaceOwner", _userspaceOwner.ToLinkSyncObject(context));
members.Add("_titleButtons", _titleButtons.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("_highlightedButton", _highlightedButton_Element.ToLinkReference(context));
members.Add("_pinButton", _pinButton_Element.ToLinkReference(context));
}

}
}
