
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxTool
// Generated on: pátek 13. února 2026 23:23:08
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SpawnNodeType", SpawnNodeType.ToResoniteLinkField());
members.Add("WirePoint", new ResoniteLink.Reference() { });
members.Add("MaxConnectDistance", MaxConnectDistance.ToResoniteLinkField());
members.Add("SelectionProgress", SelectionProgress.ToResoniteLinkField());
members.Add("HoveringElementName", HoveringElementName.ToResoniteLinkField());
members.Add("HoveringElementContentType", HoveringElementContentType.ToResoniteLinkField());
members.Add("HoveringElementColor", HoveringElementColor.ToResoniteLinkField());
members.Add("_selectedNodes", new ResoniteLink.SyncList()
{
    Elements = _selectedNodes.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_wirePointPosition", new ResoniteLink.Reference() { });
members.Add("_text", new ResoniteLink.Reference() { });
members.Add("_currentProxy", new ResoniteLink.Reference() { });
members.Add("_currentTempWire", new ResoniteLink.Reference() { });
members.Add("_currentCutLine", new ResoniteLink.Reference() { });
members.Add("_cutLineScale", new ResoniteLink.Reference() { });
members.Add("_cutLineOrientation", new ResoniteLink.Reference() { });
members.Add("_currentHighlightedNode", new ResoniteLink.Reference() { });
}

}
}
