
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Transform.SetGlobalTransformMatrix
// Generated on: čtvrtek 19. února 2026 8:00:14
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Transform
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Transform.SetGlobalTransformMatrix")]
public partial class SetGlobalTransformMatrix : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Transform.TransformSetter

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Matrix4x4> Matrix;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Matrix", Matrix.ToResoniteReference(context));
}

}
}
