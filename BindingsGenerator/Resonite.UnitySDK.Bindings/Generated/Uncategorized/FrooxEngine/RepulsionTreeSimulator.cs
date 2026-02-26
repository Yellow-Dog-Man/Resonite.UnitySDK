
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RepulsionTreeSimulator
// Generated on: čtvrtek 26. února 2026 12:28:13
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RepulsionTreeSimulator")]
public partial class RepulsionTreeSimulator : global::FrooxEngine.Component, global::FrooxEngine.IRepulsionTreeNode

{
    public global::System.Single FalloffPower { get => FalloffPower_Element.Data; set => FalloffPower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FalloffPower_Element = new();
public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Single Force { get => Force_Element.Data; set => Force_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Force_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FalloffPower", FalloffPower_Element.ToLinkField(context));
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("Force", Force_Element.ToLinkField(context));
}

}
}
