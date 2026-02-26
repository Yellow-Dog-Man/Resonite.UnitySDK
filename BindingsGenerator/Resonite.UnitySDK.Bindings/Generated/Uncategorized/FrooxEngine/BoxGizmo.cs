
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxGizmo
// Generated on: čtvrtek 26. února 2026 10:04:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoxGizmo")]
public partial class BoxGizmo : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.Slot TargetSlot { get => TargetSlot_Element.Data; set => TargetSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TargetSlot_Element = new();
public global::FrooxEngine.RootSpace BoxCenterSpace = new();
public global::FrooxEngine.RootSpace BoxSizeSpace = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> BoxSize { get => BoxSize_Element.Data; set => BoxSize_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>> BoxSize_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> BoxCenter { get => BoxCenter_Element.Data; set => BoxCenter_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>> BoxCenter_Element = new();
public global::System.Boolean LockOffset { get => LockOffset_Element.Data; set => LockOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LockOffset_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>, Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>>> _vertices = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>, Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>>> _edges = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>, Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>>> _faces = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>, Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>>> _sphereColliderRadii = new();
public global::FrooxEngine.OverlayFresnelMaterial _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.OverlayFresnelMaterial>, global::FrooxEngine.OverlayFresnelMaterial> _material_Element = new();
public global::FrooxEngine.IcoSphereMesh _handleSphere { get => _handleSphere_Element.Data; set => _handleSphere_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IcoSphereMesh>, global::FrooxEngine.IcoSphereMesh> _handleSphere_Element = new();
public global::FrooxEngine.Slot _visualRoot { get => _visualRoot_Element.Data; set => _visualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visualRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualPosition { get => _visualPosition_Element.Data; set => _visualPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _visualPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRotation { get => _visualRotation_Element.Data; set => _visualRotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _visualRotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualScale { get => _visualScale_Element.Data; set => _visualScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _visualScale_Element = new();
public global::FrooxEngine.TubeBoxMesh _tubeBox { get => _tubeBox_Element.Data; set => _tubeBox_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.TubeBoxMesh>, global::FrooxEngine.TubeBoxMesh> _tubeBox_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSlot", TargetSlot_Element.Data.ToResoniteReference(context));
members.Add("BoxCenterSpace", new ResoniteLink.SyncObject() { Members = BoxCenterSpace.CollectMembers(context) });
members.Add("BoxSizeSpace", new ResoniteLink.SyncObject() { Members = BoxSizeSpace.CollectMembers(context) });
members.Add("BoxSize", BoxSize_Element.Data.ToResoniteReference(context));
members.Add("BoxCenter", BoxCenter_Element.Data.ToResoniteReference(context));
members.Add("LockOffset", LockOffset_Element.Data.ToResoniteLinkField());
members.Add("_vertices", new ResoniteLink.SyncList()
{
    Elements = _vertices.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_edges", new ResoniteLink.SyncList()
{
    Elements = _edges.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_faces", new ResoniteLink.SyncList()
{
    Elements = _faces.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_sphereColliderRadii", new ResoniteLink.SyncList()
{
    Elements = _sphereColliderRadii.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_material", _material_Element.Data.ToResoniteReference(context));
members.Add("_handleSphere", _handleSphere_Element.Data.ToResoniteReference(context));
members.Add("_visualRoot", _visualRoot_Element.Data.ToResoniteReference(context));
members.Add("_visualPosition", _visualPosition_Element.Data.ToResoniteReference(context));
members.Add("_visualRotation", _visualRotation_Element.Data.ToResoniteReference(context));
members.Add("_visualScale", _visualScale_Element.Data.ToResoniteReference(context));
members.Add("_tubeBox", _tubeBox_Element.Data.ToResoniteReference(context));
}

}
}
