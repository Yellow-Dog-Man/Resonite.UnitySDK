
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxGizmo
// Generated on: středa 25. února 2026 16:14:35
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
    public global::FrooxEngine.Slot TargetSlot;
public global::FrooxEngine.RootSpace BoxCenterSpace;
public global::FrooxEngine.RootSpace BoxSizeSpace;
public global::FrooxEngine.IField<UnityEngine.Vector3> BoxSize;
public global::FrooxEngine.IField<UnityEngine.Vector3> BoxCenter;
public global::System.Boolean LockOffset;
public System.Collections.Generic.List<global::FrooxEngine.IField<UnityEngine.Vector3>> _vertices;
public System.Collections.Generic.List<global::FrooxEngine.IField<UnityEngine.Vector3>> _edges;
public System.Collections.Generic.List<global::FrooxEngine.IField<UnityEngine.Vector3>> _faces;
public System.Collections.Generic.List<global::FrooxEngine.IField<global::System.Single>> _sphereColliderRadii;
public global::FrooxEngine.OverlayFresnelMaterial _material;
public global::FrooxEngine.IcoSphereMesh _handleSphere;
public global::FrooxEngine.Slot _visualRoot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualPosition;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _visualRotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _visualScale;
public global::FrooxEngine.TubeBoxMesh _tubeBox;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetSlot", TargetSlot.ToResoniteReference(context));
members.Add("BoxCenterSpace", new ResoniteLink.SyncObject() { Members = BoxCenterSpace.CollectMembers(context) });
members.Add("BoxSizeSpace", new ResoniteLink.SyncObject() { Members = BoxSizeSpace.CollectMembers(context) });
members.Add("BoxSize", BoxSize.ToResoniteReference(context));
members.Add("BoxCenter", BoxCenter.ToResoniteReference(context));
members.Add("LockOffset", LockOffset.ToResoniteLinkField());
members.Add("_vertices", new ResoniteLink.SyncList()
{
    Elements = _vertices.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_edges", new ResoniteLink.SyncList()
{
    Elements = _edges.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_faces", new ResoniteLink.SyncList()
{
    Elements = _faces.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_sphereColliderRadii", new ResoniteLink.SyncList()
{
    Elements = _sphereColliderRadii.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_material", _material.ToResoniteReference(context));
members.Add("_handleSphere", _handleSphere.ToResoniteReference(context));
members.Add("_visualRoot", _visualRoot.ToResoniteReference(context));
members.Add("_visualPosition", _visualPosition.ToResoniteReference(context));
members.Add("_visualRotation", _visualRotation.ToResoniteReference(context));
members.Add("_visualScale", _visualScale.ToResoniteReference(context));
members.Add("_tubeBox", _tubeBox.ToResoniteReference(context));
}

}
}
