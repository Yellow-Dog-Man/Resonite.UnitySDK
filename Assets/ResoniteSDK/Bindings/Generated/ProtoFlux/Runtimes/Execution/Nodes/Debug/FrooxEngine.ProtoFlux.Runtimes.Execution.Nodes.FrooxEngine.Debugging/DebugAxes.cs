
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugAxes
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Position", new ResoniteLink.Reference() { });
members.Add("Rotation", new ResoniteLink.Reference() { });
members.Add("Length", new ResoniteLink.Reference() { });
members.Add("RightColor", new ResoniteLink.Reference() { });
members.Add("UpColor", new ResoniteLink.Reference() { });
members.Add("ForwardColor", new ResoniteLink.Reference() { });
members.Add("Duration", new ResoniteLink.Reference() { });
}

}
}
