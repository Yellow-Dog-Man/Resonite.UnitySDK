
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugAxes
// Generated on: úterý 24. února 2026 18:19:10
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugAxes")]
public partial class DebugAxes : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugNode

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Position;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion> Rotation;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Length;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> RightColor;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> UpColor;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> ForwardColor;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Duration;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position.ToResoniteReference(context));
members.Add("Rotation", Rotation.ToResoniteReference(context));
members.Add("Length", Length.ToResoniteReference(context));
members.Add("RightColor", RightColor.ToResoniteReference(context));
members.Add("UpColor", UpColor.ToResoniteReference(context));
members.Add("ForwardColor", ForwardColor.ToResoniteReference(context));
members.Add("Duration", Duration.ToResoniteReference(context));
}

}
}
