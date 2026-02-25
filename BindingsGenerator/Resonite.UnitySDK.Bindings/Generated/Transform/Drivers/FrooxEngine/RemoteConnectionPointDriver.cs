
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RemoteConnectionPointDriver
// Generated on: středa 25. února 2026 16:14:30
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RemoteConnectionPointDriver")]
public partial class RemoteConnectionPointDriver : global::FrooxEngine.Component

{
    public global::System.Single FilterThreshold;
public global::FrooxEngine.Slot TargetPoint;
public UnityEngine.Vector3 TargetVector;
public global::System.Single TargetSize;
public UnityEngine.Quaternion TargetOrientation;
public global::FrooxEngine.IField<UnityEngine.Vector3> LocalPoint;
public global::FrooxEngine.IField<UnityEngine.Vector3> LocalVector;
public global::FrooxEngine.IField<UnityEngine.Quaternion> LocalOrientation;
public global::FrooxEngine.IField<global::System.Single> LocalSize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FilterThreshold", FilterThreshold.ToResoniteLinkField());
members.Add("TargetPoint", TargetPoint.ToResoniteReference(context));
members.Add("TargetVector", TargetVector.ToResoniteLinkField());
members.Add("TargetSize", TargetSize.ToResoniteLinkField());
members.Add("TargetOrientation", TargetOrientation.ToResoniteLinkField());
members.Add("LocalPoint", LocalPoint.ToResoniteReference(context));
members.Add("LocalVector", LocalVector.ToResoniteReference(context));
members.Add("LocalOrientation", LocalOrientation.ToResoniteReference(context));
members.Add("LocalSize", LocalSize.ToResoniteReference(context));
}

}
}
