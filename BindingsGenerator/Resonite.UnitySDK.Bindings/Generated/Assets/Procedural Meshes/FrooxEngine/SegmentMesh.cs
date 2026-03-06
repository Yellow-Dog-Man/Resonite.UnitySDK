
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SegmentMesh
// Generated on: pátek 6. března 2026 14:18:05
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SegmentMesh")]
public partial class SegmentMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public UnityEngine.Vector3 PointA { get => PointA_Element.Data; set => PointA_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> PointA_Element = new();
public UnityEngine.Vector3 PointB { get => PointB_Element.Data; set => PointB_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> PointB_Element = new();
public global::FrooxEngine.Slot SlotA { get => SlotA_Element.Data; set => SlotA_Element.Data = value; }
public Reference<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> SlotA_Element = new();
public global::FrooxEngine.Slot SlotB { get => SlotB_Element.Data; set => SlotB_Element.Data = value; }
public Reference<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> SlotB_Element = new();
public global::Elements.Assets.SegmentedBuilder.Shading Shading { get => Shading_Element.Data; set => Shading_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.SegmentedBuilder.Shading>, global::Elements.Assets.SegmentedBuilder.Shading> Shading_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("PointA", PointA_Element.ToLinkField(context));
members.Add("PointB", PointB_Element.ToLinkField(context));
members.Add("SlotA", SlotA_Element.ToLinkReference(context));
members.Add("SlotB", SlotB_Element.ToLinkReference(context));
members.Add("Shading", Shading_Element.ToLinkField(context));
}

}
}
