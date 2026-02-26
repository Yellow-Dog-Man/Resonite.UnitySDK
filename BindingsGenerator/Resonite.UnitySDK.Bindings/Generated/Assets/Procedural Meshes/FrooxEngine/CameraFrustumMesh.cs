
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CameraFrustumMesh
// Generated on: čtvrtek 26. února 2026 10:03:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CameraFrustumMesh")]
public partial class CameraFrustumMesh : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Quaternion Orientation { get => Orientation_Element.Data; set => Orientation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> Orientation_Element = new();
public global::System.Single Near { get => Near_Element.Data; set => Near_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Near_Element = new();
public global::System.Single Far { get => Far_Element.Data; set => Far_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Far_Element = new();
public global::System.Single HorizontalAngle { get => HorizontalAngle_Element.Data; set => HorizontalAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HorizontalAngle_Element = new();
public global::System.Single VerticalAngle { get => VerticalAngle_Element.Data; set => VerticalAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VerticalAngle_Element = new();
public global::System.Boolean DualSided { get => DualSided_Element.Data; set => DualSided_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DualSided_Element = new();
public global::System.Boolean NearCap { get => NearCap_Element.Data; set => NearCap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> NearCap_Element = new();
public global::System.Boolean FarCap { get => FarCap_Element.Data; set => FarCap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FarCap_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Orientation", Orientation_Element.Data.ToResoniteLinkField());
members.Add("Near", Near_Element.Data.ToResoniteLinkField());
members.Add("Far", Far_Element.Data.ToResoniteLinkField());
members.Add("HorizontalAngle", HorizontalAngle_Element.Data.ToResoniteLinkField());
members.Add("VerticalAngle", VerticalAngle_Element.Data.ToResoniteLinkField());
members.Add("DualSided", DualSided_Element.Data.ToResoniteLinkField());
members.Add("NearCap", NearCap_Element.Data.ToResoniteLinkField());
members.Add("FarCap", FarCap_Element.Data.ToResoniteLinkField());
}

}
}
