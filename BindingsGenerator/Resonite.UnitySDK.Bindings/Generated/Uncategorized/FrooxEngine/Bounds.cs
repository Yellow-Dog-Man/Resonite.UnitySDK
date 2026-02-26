
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Bounds
// Generated on: čtvrtek 26. února 2026 10:04:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Bounds")]
public partial class Bounds : global::FrooxEngine.Component, global::FrooxEngine.IBounded

{
    public global::System.Boolean Available { get => Available_Element.Data; set => Available_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Available_Element = new();
public UnityEngine.Bounds LocalBounds { get => LocalBounds_Element.Data; set => LocalBounds_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Bounds>, UnityEngine.Bounds> LocalBounds_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Available", Available_Element.Data.ToResoniteLinkField());
members.Add("LocalBounds", LocalBounds_Element.Data.ToResoniteLinkField());
}

}
}
