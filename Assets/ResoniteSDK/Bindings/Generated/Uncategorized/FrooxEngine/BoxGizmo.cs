
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoxGizmo
// Generated on: pátek 13. února 2026 5:52:29
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetSlot", new ResoniteLink.Reference() { });
members.Add("BoxCenterSpace", new ResoniteLink.SyncObject() { Members = BoxCenterSpace.CollectMembers() });
members.Add("BoxSizeSpace", new ResoniteLink.SyncObject() { Members = BoxSizeSpace.CollectMembers() });
members.Add("BoxSize", new ResoniteLink.Reference() { });
members.Add("BoxCenter", new ResoniteLink.Reference() { });
members.Add("LockOffset", LockOffset.ToResoniteLinkField());
members.Add("_vertices", new ResoniteLink.SyncList()
{
    Elements = _vertices.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("_edges", new ResoniteLink.SyncList()
{
    Elements = _edges.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("_faces", new ResoniteLink.SyncList()
{
    Elements = _faces.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("_sphereColliderRadii", new ResoniteLink.SyncList()
{
    Elements = _sphereColliderRadii.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("_material", new ResoniteLink.Reference() { });
members.Add("_handleSphere", new ResoniteLink.Reference() { });
members.Add("_visualRoot", new ResoniteLink.Reference() { });
members.Add("_visualPosition", new ResoniteLink.Reference() { });
members.Add("_visualRotation", new ResoniteLink.Reference() { });
members.Add("_visualScale", new ResoniteLink.Reference() { });
members.Add("_tubeBox", new ResoniteLink.Reference() { });
}

}
}
