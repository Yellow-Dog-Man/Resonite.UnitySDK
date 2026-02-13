
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyPanel
// Generated on: pátek 13. února 2026 23:23:15
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ShowHeader", ShowHeader.ToResoniteLinkField());
members.Add("ShowHandle", ShowHandle.ToResoniteLinkField());
members.Add("Padding", Padding.ToResoniteLinkField());
members.Add("ZPadding", ZPadding.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("WhiteList", new ResoniteLink.SyncList()
{
    Elements = WhiteList.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("BlackList", new ResoniteLink.SyncList()
{
    Elements = BlackList.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("Color", Color.ToResoniteLinkField());
members.Add("_material", new ResoniteLink.Reference() { });
members.Add("_panelMesh", new ResoniteLink.Reference() { });
members.Add("_panelPos", new ResoniteLink.Reference() { });
members.Add("_handleActive", new ResoniteLink.Reference() { });
members.Add("_headerActive", new ResoniteLink.Reference() { });
members.Add("_handleMesh", new ResoniteLink.Reference() { });
members.Add("_handlePos", new ResoniteLink.Reference() { });
members.Add("_handleColliderSize", new ResoniteLink.Reference() { });
members.Add("_headerTitleMesh", new ResoniteLink.Reference() { });
members.Add("_headerButtonMesh", new ResoniteLink.Reference() { });
members.Add("_headerCollider", new ResoniteLink.Reference() { });
members.Add("_headerPos", new ResoniteLink.Reference() { });
members.Add("_headerTitlePos", new ResoniteLink.Reference() { });
members.Add("_title", _title.ToResoniteLinkField());
members.Add("_titleText", new ResoniteLink.Reference() { });
members.Add("_indicatePrivate", _indicatePrivate.ToResoniteLinkField());
members.Add("_titlePos", new ResoniteLink.Reference() { });
members.Add("_titleBounds", new ResoniteLink.Reference() { });
members.Add("_contentSlot", new ResoniteLink.Reference() { });
members.Add("_headerRoot", new ResoniteLink.Reference() { });
members.Add("_handleAnchorPoint", new ResoniteLink.Reference() { });
members.Add("_handleAnchorPointPosition", new ResoniteLink.Reference() { });
members.Add("_userspaceOwner", new ResoniteLink.SyncObject() { Members = _userspaceOwner.CollectMembers() });
members.Add("_titleButtons", new ResoniteLink.SyncList()
{
    Elements = _titleButtons.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("_highlightedButton", new ResoniteLink.Reference() { });
members.Add("_pinButton", new ResoniteLink.Reference() { });
}

}
}
