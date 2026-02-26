
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.ToAxisAngle_floatQ
// Generated on: čtvrtek 26. února 2026 12:27:42
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.ToAxisAngle_floatQ")]
public partial class ToAxisAngle_floatQ : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion> Q { get => Q_Element.Data; set => Q_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion>> Q_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Axis = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> Angle = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Q", Q_Element.ToLinkReference(context));
members.Add("Axis", Axis.ToLinkEmpty(context));
members.Add("Angle", Angle.ToLinkEmpty(context));
}

}
}
