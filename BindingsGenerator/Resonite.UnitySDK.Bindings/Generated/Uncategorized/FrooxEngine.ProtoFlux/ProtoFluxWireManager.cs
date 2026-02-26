
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxWireManager
// Generated on: čtvrtek 26. února 2026 10:04:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxWireManager")]
public partial class ProtoFluxWireManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot ConnectPoint { get => ConnectPoint_Element.Data; set => ConnectPoint_Element.Data = value; }
public Field<global::FrooxEngine.TransformRelayRef, global::FrooxEngine.Slot> ConnectPoint_Element = new();
public global::FrooxEngine.ProtoFlux.WireType Type { get => Type_Element.Data; set => Type_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ProtoFlux.WireType>, global::FrooxEngine.ProtoFlux.WireType> Type_Element = new();
public global::System.Single Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Width_Element = new();
public UnityEngine.ColorX StartColor { get => StartColor_Element.Data; set => StartColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> StartColor_Element = new();
public UnityEngine.ColorX EndColor { get => EndColor_Element.Data; set => EndColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EndColor_Element = new();
public global::System.Boolean DeleteHighlight { get => DeleteHighlight_Element.Data; set => DeleteHighlight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DeleteHighlight_Element = new();
public global::FrooxEngine.StripeWireMesh _wireMesh { get => _wireMesh_Element.Data; set => _wireMesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.StripeWireMesh>, global::FrooxEngine.StripeWireMesh> _wireMesh_Element = new();
public global::FrooxEngine.MeshRenderer _renderer { get => _renderer_Element.Data; set => _renderer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> _renderer_Element = new();
public global::FrooxEngine.MeshCollider _collider { get => _collider_Element.Data; set => _collider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshCollider>, global::FrooxEngine.MeshCollider> _collider_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _targetPosition { get => _targetPosition_Element.Data; set => _targetPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _targetPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _targetTangent { get => _targetTangent_Element.Data; set => _targetTangent_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _targetTangent_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _targetOrientation { get => _targetOrientation_Element.Data; set => _targetOrientation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _targetOrientation_Element = new();
public global::FrooxEngine.IField<global::System.Single> _targetWidth { get => _targetWidth_Element.Data; set => _targetWidth_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _targetWidth_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ConnectPoint", ConnectPoint_Element.Data.ToResoniteReference(context));
members.Add("Type", Type_Element.Data.ToResoniteLinkField());
members.Add("Width", Width_Element.Data.ToResoniteLinkField());
members.Add("StartColor", StartColor_Element.Data.ToResoniteLinkField());
members.Add("EndColor", EndColor_Element.Data.ToResoniteLinkField());
members.Add("DeleteHighlight", DeleteHighlight_Element.Data.ToResoniteLinkField());
members.Add("_wireMesh", _wireMesh_Element.Data.ToResoniteReference(context));
members.Add("_renderer", _renderer_Element.Data.ToResoniteReference(context));
members.Add("_collider", _collider_Element.Data.ToResoniteReference(context));
members.Add("_targetPosition", _targetPosition_Element.Data.ToResoniteReference(context));
members.Add("_targetTangent", _targetTangent_Element.Data.ToResoniteReference(context));
members.Add("_targetOrientation", _targetOrientation_Element.Data.ToResoniteReference(context));
members.Add("_targetWidth", _targetWidth_Element.Data.ToResoniteReference(context));
}

}
}
