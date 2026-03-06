
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.AxisAngle_doubleQ
// Generated on: pátek 6. března 2026 14:18:48
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Quaternions.AxisAngle_doubleQ")]
public partial class AxisAngle_doubleQ : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.QuaternionDouble>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Double> Axis { get => Axis_Element.Data; set => Axis_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3Double>> Axis_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double> Angle { get => Angle_Element.Data; set => Angle_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Double>> Angle_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Axis", Axis_Element.ToLinkReference(context));
members.Add("Angle", Angle_Element.ToLinkReference(context));
}

}
}
