
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiBevelStripeMesh+Stripe
// Generated on: pátek 13. února 2026 5:51:09
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
    public partial class MultiBevelStripeMesh
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiBevelStripeMesh+Stripe")]
public partial class Stripe : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Position;
public UnityEngine.Quaternion Rotation;
public UnityEngine.Vector3 Scale;
public global::System.Single Width;
public global::System.Single Height;
public global::System.Single Thickness;
public global::System.Single SlantLeft;
public global::System.Single SlantRight;
public global::System.Boolean Relief;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Position", Position.ToResoniteLinkField());
members.Add("Rotation", Rotation.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("SlantLeft", SlantLeft.ToResoniteLinkField());
members.Add("SlantRight", SlantRight.ToResoniteLinkField());
members.Add("Relief", Relief.ToResoniteLinkField());
}

}
            }
}
