
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshPlaneBrushTool
// Generated on: čtvrtek 26. února 2026 12:28:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshPlaneBrushTool")]
public partial class MeshPlaneBrushTool : global::FrooxEngine.BrushTool

{
    public global::FrooxEngine.Slot TipAnchor { get => TipAnchor_Element.Data; set => TipAnchor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TipAnchor_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer>> MaterialPreviews = new();
public global::FrooxEngine.ConstrainedDelaunayMesh _currentMesh { get => _currentMesh_Element.Data; set => _currentMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ConstrainedDelaunayMesh>, global::FrooxEngine.ConstrainedDelaunayMesh> _currentMesh_Element = new();
public global::FrooxEngine.ConstrainedDelaunayMesh.Hole _currentHole { get => _currentHole_Element.Data; set => _currentHole_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ConstrainedDelaunayMesh.Hole>, global::FrooxEngine.ConstrainedDelaunayMesh.Hole> _currentHole_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TipAnchor", TipAnchor_Element.ToLinkReference(context));
members.Add("MaterialPreviews", MaterialPreviews.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_currentMesh", _currentMesh_Element.ToLinkReference(context));
members.Add("_currentHole", _currentHole_Element.ToLinkReference(context));
}

}
}
