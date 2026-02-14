
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SimplexCubemap
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SimplexCubemap")]
public partial class SimplexCubemap : global::FrooxEngine.ProceduralCubemap

{
    public UnityEngine.ColorX Background;
public UnityEngine.ColorX Foreground;
public global::System.Single Scale;
public global::System.Boolean Use4D;
public global::System.Single WOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Background", Background.ToResoniteLinkField());
members.Add("Foreground", Foreground.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Use4D", Use4D.ToResoniteLinkField());
members.Add("WOffset", WOffset.ToResoniteLinkField());
}

}
}
