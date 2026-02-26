
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DiagnosticGaussianSplat+SplatData
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
    public partial class DiagnosticGaussianSplat
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DiagnosticGaussianSplat+SplatData")]
public partial class SplatData : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Position_Element = new();
public UnityEngine.Quaternion Rotation { get => Rotation_Element.Data; set => Rotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> Rotation_Element = new();
public UnityEngine.Vector3 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Scale_Element = new();
public global::System.Single Alpha { get => Alpha_Element.Data; set => Alpha_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Alpha_Element = new();
public global::Elements.Core.SphericalHarmonicsL3<UnityEngine.Color> Colors { get => Colors_Element.Data; set => Colors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.SphericalHarmonicsL3<UnityEngine.Color>>, global::Elements.Core.SphericalHarmonicsL3<UnityEngine.Color>> Colors_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position_Element.Data.ToResoniteLinkField());
members.Add("Rotation", Rotation_Element.Data.ToResoniteLinkField());
members.Add("Scale", Scale_Element.Data.ToResoniteLinkField());
members.Add("Alpha", Alpha_Element.Data.ToResoniteLinkField());
members.Add("Colors", Colors_Element.Data.ToResoniteLinkField());
}

}
            }
}
