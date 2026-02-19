
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxWireManager
// Generated on: čtvrtek 19. února 2026 8:00:30
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ConnectPoint", ConnectPoint.ToResoniteReference(context));
members.Add("Type", Type.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("StartColor", StartColor.ToResoniteLinkField());
members.Add("EndColor", EndColor.ToResoniteLinkField());
members.Add("DeleteHighlight", DeleteHighlight.ToResoniteLinkField());
members.Add("_wireMesh", _wireMesh.ToResoniteReference(context));
members.Add("_renderer", _renderer.ToResoniteReference(context));
members.Add("_collider", _collider.ToResoniteReference(context));
members.Add("_targetPosition", _targetPosition.ToResoniteReference(context));
members.Add("_targetTangent", _targetTangent.ToResoniteReference(context));
members.Add("_targetOrientation", _targetOrientation.ToResoniteReference(context));
members.Add("_targetWidth", _targetWidth.ToResoniteReference(context));
}

}
}
