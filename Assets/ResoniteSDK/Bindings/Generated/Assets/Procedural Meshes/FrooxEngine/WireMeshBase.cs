
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WireMeshBase
// Generated on: úterý 24. února 2026 18:17:41
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WireMeshBase")]
public abstract partial class WireMeshBase : global::FrooxEngine.ProceduralMesh

{
    public UnityEngine.Vector3 Point0;
public UnityEngine.Vector3 Point1;
public UnityEngine.Vector3 Tangent0;
public UnityEngine.Vector3 Tangent1;
public UnityEngine.Quaternion Orientation0;
public UnityEngine.Quaternion Orientation1;
public global::System.Int32 Steps;
public global::System.Single Exp;
public UnityEngine.ColorX Color0;
public UnityEngine.ColorX Color1;
public UnityEngine.Vector2 UVScale;
public UnityEngine.Vector2 UVOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point0", Point0.ToResoniteLinkField());
members.Add("Point1", Point1.ToResoniteLinkField());
members.Add("Tangent0", Tangent0.ToResoniteLinkField());
members.Add("Tangent1", Tangent1.ToResoniteLinkField());
members.Add("Orientation0", Orientation0.ToResoniteLinkField());
members.Add("Orientation1", Orientation1.ToResoniteLinkField());
members.Add("Steps", Steps.ToResoniteLinkField());
members.Add("Exp", Exp.ToResoniteLinkField());
members.Add("Color0", Color0.ToResoniteLinkField());
members.Add("Color1", Color1.ToResoniteLinkField());
members.Add("UVScale", UVScale.ToResoniteLinkField());
members.Add("UVOffset", UVOffset.ToResoniteLinkField());
}

}
}
