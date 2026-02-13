
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SimplexTexture3D
// Generated on: pátek 13. února 2026 23:21:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SimplexTexture3D")]
public partial class SimplexTexture3D : global::FrooxEngine.ProceduralTexture3D

{
    public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 Scale;
public UnityEngine.ColorX Background;
public UnityEngine.ColorX Foreground;
public global::System.Boolean Use4D;
public global::System.Single WOffset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Background", Background.ToResoniteLinkField());
members.Add("Foreground", Foreground.ToResoniteLinkField());
members.Add("Use4D", Use4D.ToResoniteLinkField());
members.Add("WOffset", WOffset.ToResoniteLinkField());
}

}
}
