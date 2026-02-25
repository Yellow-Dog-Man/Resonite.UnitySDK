
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SimplexTexture
// Generated on: středa 25. února 2026 16:13:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SimplexTexture")]
public partial class SimplexTexture : global::FrooxEngine.ProceduralTexture

{
    public UnityEngine.Vector2 Offset;
public UnityEngine.Vector2 Scale;
public UnityEngine.ColorX Background;
public UnityEngine.ColorX Foreground;
public global::System.Boolean Use3D;
public global::System.Single ZOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Background", Background.ToResoniteLinkField());
members.Add("Foreground", Foreground.ToResoniteLinkField());
members.Add("Use3D", Use3D.ToResoniteLinkField());
members.Add("ZOffset", ZOffset.ToResoniteLinkField());
}

}
}
