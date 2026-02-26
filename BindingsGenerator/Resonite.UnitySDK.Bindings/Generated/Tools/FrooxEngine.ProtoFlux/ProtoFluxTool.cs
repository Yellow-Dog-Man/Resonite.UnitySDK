
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxTool
// Generated on: čtvrtek 26. února 2026 10:04:39
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxTool")]
public partial class ProtoFluxTool : global::FrooxEngine.Tool

{
    public System.String SpawnNodeType { get => SpawnNodeType_Element.Data; set => SpawnNodeType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> SpawnNodeType_Element = new();
public global::FrooxEngine.Slot WirePoint { get => WirePoint_Element.Data; set => WirePoint_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> WirePoint_Element = new();
public global::System.Single MaxConnectDistance { get => MaxConnectDistance_Element.Data; set => MaxConnectDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxConnectDistance_Element = new();
public global::System.Single SelectionProgress { get => SelectionProgress_Element.Data; set => SelectionProgress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SelectionProgress_Element = new();
public global::System.String HoveringElementName { get => HoveringElementName_Element.Data; set => HoveringElementName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> HoveringElementName_Element = new();
public System.String HoveringElementContentType { get => HoveringElementContentType_Element.Data; set => HoveringElementContentType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> HoveringElementContentType_Element = new();
public UnityEngine.ColorX HoveringElementColor { get => HoveringElementColor_Element.Data; set => HoveringElementColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> HoveringElementColor_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual>, global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual>, global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual>> _selectedNodes = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _wirePointPosition { get => _wirePointPosition_Element.Data; set => _wirePointPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _wirePointPosition_Element = new();
public global::FrooxEngine.TextRenderer _text { get => _text_Element.Data; set => _text_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _text_Element = new();
public global::FrooxEngine.ProtoFlux.ProtoFluxElementProxy _currentProxy { get => _currentProxy_Element.Data; set => _currentProxy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ProtoFluxElementProxy>, global::FrooxEngine.ProtoFlux.ProtoFluxElementProxy> _currentProxy_Element = new();
public global::FrooxEngine.Slot _currentTempWire { get => _currentTempWire_Element.Data; set => _currentTempWire_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _currentTempWire_Element = new();
public global::FrooxEngine.Slot _currentCutLine { get => _currentCutLine_Element.Data; set => _currentCutLine_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _currentCutLine_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _cutLineScale { get => _cutLineScale_Element.Data; set => _cutLineScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _cutLineScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _cutLineOrientation { get => _cutLineOrientation_Element.Data; set => _cutLineOrientation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _cutLineOrientation_Element = new();
public global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual _currentHighlightedNode { get => _currentHighlightedNode_Element.Data; set => _currentHighlightedNode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual>, global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual> _currentHighlightedNode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpawnNodeType", SpawnNodeType_Element.Data.ToResoniteLinkField());
members.Add("WirePoint", WirePoint_Element.Data.ToResoniteReference(context));
members.Add("MaxConnectDistance", MaxConnectDistance_Element.Data.ToResoniteLinkField());
members.Add("SelectionProgress", SelectionProgress_Element.Data.ToResoniteLinkField());
members.Add("HoveringElementName", HoveringElementName_Element.Data.ToResoniteLinkField());
members.Add("HoveringElementContentType", HoveringElementContentType_Element.Data.ToResoniteLinkField());
members.Add("HoveringElementColor", HoveringElementColor_Element.Data.ToResoniteLinkField());
members.Add("_selectedNodes", new ResoniteLink.SyncList()
{
    Elements = _selectedNodes.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_wirePointPosition", _wirePointPosition_Element.Data.ToResoniteReference(context));
members.Add("_text", _text_Element.Data.ToResoniteReference(context));
members.Add("_currentProxy", _currentProxy_Element.Data.ToResoniteReference(context));
members.Add("_currentTempWire", _currentTempWire_Element.Data.ToResoniteReference(context));
members.Add("_currentCutLine", _currentCutLine_Element.Data.ToResoniteReference(context));
members.Add("_cutLineScale", _cutLineScale_Element.Data.ToResoniteReference(context));
members.Add("_cutLineOrientation", _cutLineOrientation_Element.Data.ToResoniteReference(context));
members.Add("_currentHighlightedNode", _currentHighlightedNode_Element.Data.ToResoniteReference(context));
}

}
}
