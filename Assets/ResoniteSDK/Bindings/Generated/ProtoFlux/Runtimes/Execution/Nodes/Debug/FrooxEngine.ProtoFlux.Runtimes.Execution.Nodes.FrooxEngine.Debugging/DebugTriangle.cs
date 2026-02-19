
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugTriangle
// Generated on: čtvrtek 19. února 2026 7:59:49
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugTriangle")]
public partial class DebugTriangle : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugNode

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> Color;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Duration;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point0", Point0.ToResoniteReference(context));
members.Add("Point1", Point1.ToResoniteReference(context));
members.Add("Point2", Point2.ToResoniteReference(context));
members.Add("Color", Color.ToResoniteReference(context));
members.Add("Duration", Duration.ToResoniteReference(context));
}

}
}
