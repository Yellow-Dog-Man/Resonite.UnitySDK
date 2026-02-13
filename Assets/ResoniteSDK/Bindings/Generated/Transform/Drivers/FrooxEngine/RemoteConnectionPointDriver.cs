
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RemoteConnectionPointDriver
// Generated on: pátek 13. února 2026 23:23:09
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("FilterThreshold", FilterThreshold.ToResoniteLinkField());
members.Add("TargetPoint", new ResoniteLink.Reference() { });
members.Add("TargetVector", TargetVector.ToResoniteLinkField());
members.Add("TargetSize", TargetSize.ToResoniteLinkField());
members.Add("TargetOrientation", TargetOrientation.ToResoniteLinkField());
members.Add("LocalPoint", new ResoniteLink.Reference() { });
members.Add("LocalVector", new ResoniteLink.Reference() { });
members.Add("LocalOrientation", new ResoniteLink.Reference() { });
members.Add("LocalSize", new ResoniteLink.Reference() { });
}

}
}
