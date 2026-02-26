
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Bounds
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
members.Add("Available", Available_Element.ToLinkField(context));
members.Add("LocalBounds", LocalBounds_Element.ToLinkField(context));
}

}
}
