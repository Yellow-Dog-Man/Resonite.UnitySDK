
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxWireManager
// Generated on: pátek 13. února 2026 5:52:35
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxWireManager")]
public partial class ProtoFluxWireManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot ConnectPoint;
public global::FrooxEngine.ProtoFlux.WireType Type;
public global::System.Single Width;
public UnityEngine.ColorX StartColor;
public UnityEngine.ColorX EndColor;
public global::System.Boolean DeleteHighlight;
public global::FrooxEngine.StripeWireMesh _wireMesh;
public global::FrooxEngine.MeshRenderer _renderer;
public global::FrooxEngine.MeshCollider _collider;
public global::FrooxEngine.IField<UnityEngine.Vector3> _targetPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _targetTangent;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _targetOrientation;
public global::FrooxEngine.IField<global::System.Single> _targetWidth;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ConnectPoint", new ResoniteLink.Reference() { });
members.Add("Type", Type.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("StartColor", StartColor.ToResoniteLinkField());
members.Add("EndColor", EndColor.ToResoniteLinkField());
members.Add("DeleteHighlight", DeleteHighlight.ToResoniteLinkField());
members.Add("_wireMesh", new ResoniteLink.Reference() { });
members.Add("_renderer", new ResoniteLink.Reference() { });
members.Add("_collider", new ResoniteLink.Reference() { });
members.Add("_targetPosition", new ResoniteLink.Reference() { });
members.Add("_targetTangent", new ResoniteLink.Reference() { });
members.Add("_targetOrientation", new ResoniteLink.Reference() { });
members.Add("_targetWidth", new ResoniteLink.Reference() { });
}

}
}
