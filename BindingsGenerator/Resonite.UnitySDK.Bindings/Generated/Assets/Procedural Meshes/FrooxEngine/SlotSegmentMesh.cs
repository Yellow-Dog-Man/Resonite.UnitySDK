
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotSegmentMesh
// Generated on: čtvrtek 26. února 2026 12:26:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotSegmentMesh")]
public partial class SlotSegmentMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::FrooxEngine.Slot PointA { get => PointA_Element.Data; set => PointA_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> PointA_Element = new();
public global::FrooxEngine.Slot PointB { get => PointB_Element.Data; set => PointB_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> PointB_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("PointA", PointA_Element.ToLinkReference(context));
members.Add("PointB", PointB_Element.ToLinkReference(context));
}

}
}
