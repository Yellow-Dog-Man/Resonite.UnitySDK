
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugVector
// Generated on: pátek 13. února 2026 23:22:28
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugVector")]
public partial class DebugVector : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugNode

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Position;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Vector;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> Color;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> RadiusRatio;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Duration;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Position", new ResoniteLink.Reference() { });
members.Add("Vector", new ResoniteLink.Reference() { });
members.Add("Color", new ResoniteLink.Reference() { });
members.Add("RadiusRatio", new ResoniteLink.Reference() { });
members.Add("Duration", new ResoniteLink.Reference() { });
}

}
}
