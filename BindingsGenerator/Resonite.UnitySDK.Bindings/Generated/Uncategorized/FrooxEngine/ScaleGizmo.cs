
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleGizmo
// Generated on: čtvrtek 26. února 2026 10:04:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleGizmo")]
public partial class ScaleGizmo : global::FrooxEngine.Gizmo

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> TargetScale { get => TargetScale_Element.Data; set => TargetScale_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>> TargetScale_Element = new();
public global::System.Single HandleLength { get => HandleLength_Element.Data; set => HandleLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HandleLength_Element = new();
public global::FrooxEngine.Slot _xSlot { get => _xSlot_Element.Data; set => _xSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _xSlot_Element = new();
public global::FrooxEngine.Slot _ySlot { get => _ySlot_Element.Data; set => _ySlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _ySlot_Element = new();
public global::FrooxEngine.Slot _zSlot { get => _zSlot_Element.Data; set => _zSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _zSlot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetScale", TargetScale_Element.Data.ToResoniteReference(context));
members.Add("HandleLength", HandleLength_Element.Data.ToResoniteLinkField());
members.Add("_xSlot", _xSlot_Element.Data.ToResoniteReference(context));
members.Add("_ySlot", _ySlot_Element.Data.ToResoniteReference(context));
members.Add("_zSlot", _zSlot_Element.Data.ToResoniteReference(context));
}

}
}
