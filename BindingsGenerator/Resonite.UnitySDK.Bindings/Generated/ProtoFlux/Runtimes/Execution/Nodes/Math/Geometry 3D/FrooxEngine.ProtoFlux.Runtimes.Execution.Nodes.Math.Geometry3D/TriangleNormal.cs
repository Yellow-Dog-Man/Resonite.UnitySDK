
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.TriangleNormal
// Generated on: čtvrtek 26. února 2026 12:27:39
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Math.Geometry3D.TriangleNormal")]
public partial class TriangleNormal : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point0 { get => Point0_Element.Data; set => Point0_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Point0_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point1 { get => Point1_Element.Data; set => Point1_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Point1_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point2 { get => Point2_Element.Data; set => Point2_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Point2_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<UnityEngine.Vector3> Normal = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsValid = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point0", Point0_Element.ToLinkReference(context));
members.Add("Point1", Point1_Element.ToLinkReference(context));
members.Add("Point2", Point2_Element.ToLinkReference(context));
members.Add("Normal", Normal.ToLinkEmpty(context));
members.Add("IsValid", IsValid.ToLinkEmpty(context));
}

}
}
