
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CameraFrustumMesh
// Generated on: pátek 13. února 2026 5:51:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CameraFrustumMesh")]
public partial class CameraFrustumMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Quaternion Orientation;
public global::System.Single Near;
public global::System.Single Far;
public global::System.Single HorizontalAngle;
public global::System.Single VerticalAngle;
public global::System.Boolean DualSided;
public global::System.Boolean NearCap;
public global::System.Boolean FarCap;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Orientation", Orientation.ToResoniteLinkField());
members.Add("Near", Near.ToResoniteLinkField());
members.Add("Far", Far.ToResoniteLinkField());
members.Add("HorizontalAngle", HorizontalAngle.ToResoniteLinkField());
members.Add("VerticalAngle", VerticalAngle.ToResoniteLinkField());
members.Add("DualSided", DualSided.ToResoniteLinkField());
members.Add("NearCap", NearCap.ToResoniteLinkField());
members.Add("FarCap", FarCap.ToResoniteLinkField());
}

}
}
