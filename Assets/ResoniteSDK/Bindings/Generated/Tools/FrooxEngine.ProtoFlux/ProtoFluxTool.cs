
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxTool
// Generated on: úterý 24. února 2026 18:20:12
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public System.String SpawnNodeType;
public global::FrooxEngine.Slot WirePoint;
public global::System.Single MaxConnectDistance;
public global::System.Single SelectionProgress;
public global::System.String HoveringElementName;
public System.String HoveringElementContentType;
public UnityEngine.ColorX HoveringElementColor;
public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual> _selectedNodes;
public global::FrooxEngine.IField<UnityEngine.Vector3> _wirePointPosition;
public global::FrooxEngine.TextRenderer _text;
public global::FrooxEngine.ProtoFlux.ProtoFluxElementProxy _currentProxy;
public global::FrooxEngine.Slot _currentTempWire;
public global::FrooxEngine.Slot _currentCutLine;
public global::FrooxEngine.IField<UnityEngine.Vector3> _cutLineScale;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _cutLineOrientation;
public global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual _currentHighlightedNode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpawnNodeType", SpawnNodeType.ToResoniteLinkField());
members.Add("WirePoint", WirePoint.ToResoniteReference(context));
members.Add("MaxConnectDistance", MaxConnectDistance.ToResoniteLinkField());
members.Add("SelectionProgress", SelectionProgress.ToResoniteLinkField());
members.Add("HoveringElementName", HoveringElementName.ToResoniteLinkField());
members.Add("HoveringElementContentType", HoveringElementContentType.ToResoniteLinkField());
members.Add("HoveringElementColor", HoveringElementColor.ToResoniteLinkField());
members.Add("_selectedNodes", new ResoniteLink.SyncList()
{
    Elements = _selectedNodes.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_wirePointPosition", _wirePointPosition.ToResoniteReference(context));
members.Add("_text", _text.ToResoniteReference(context));
members.Add("_currentProxy", _currentProxy.ToResoniteReference(context));
members.Add("_currentTempWire", _currentTempWire.ToResoniteReference(context));
members.Add("_currentCutLine", _currentCutLine.ToResoniteReference(context));
members.Add("_cutLineScale", _cutLineScale.ToResoniteReference(context));
members.Add("_cutLineOrientation", _cutLineOrientation.ToResoniteReference(context));
members.Add("_currentHighlightedNode", _currentHighlightedNode.ToResoniteReference(context));
}

}
}
