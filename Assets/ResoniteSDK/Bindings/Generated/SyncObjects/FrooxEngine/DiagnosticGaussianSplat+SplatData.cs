
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DiagnosticGaussianSplat+SplatData
// Generated on: sobota 14. února 2026 8:56:59
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public UnityEngine.Vector3 Position;
public UnityEngine.Quaternion Rotation;
public UnityEngine.Vector3 Scale;
public global::System.Single Alpha;
public global::Elements.Core.SphericalHarmonicsL3<UnityEngine.Color> Colors;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position.ToResoniteLinkField());
members.Add("Rotation", Rotation.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Alpha", Alpha.ToResoniteLinkField());
members.Add("Colors", Colors.ToResoniteLinkField());
}

}
            }
}
