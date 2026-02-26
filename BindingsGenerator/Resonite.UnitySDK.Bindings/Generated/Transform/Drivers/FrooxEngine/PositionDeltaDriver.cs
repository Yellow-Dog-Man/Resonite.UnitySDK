
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PositionDeltaDriver
// Generated on: čtvrtek 26. února 2026 10:04:41
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PositionDeltaDriver")]
public partial class PositionDeltaDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot Origin { get => Origin_Element.Data; set => Origin_Element.Data = value; }
public Field<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> Origin_Element = new();
public global::FrooxEngine.Slot Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> Target_Element = new();
public global::FrooxEngine.RootSpace VectorSpace = new();
public global::System.Boolean Normalized { get => Normalized_Element.Data; set => Normalized_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Normalized_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> Vector { get => Vector_Element.Data; set => Vector_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Vector_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Origin", Origin_Element.Data.ToResoniteReference(context));
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("VectorSpace", new ResoniteLink.SyncObject() { Members = VectorSpace.CollectMembers(context) });
members.Add("Normalized", Normalized_Element.Data.ToResoniteLinkField());
members.Add("Vector", Vector_Element.Data.ToResoniteReference(context));
}

}
}
