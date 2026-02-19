
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackRows_Float4x4
// Generated on: čtvrtek 19. února 2026 8:00:07
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Operators.PackRows_Float4x4")]
public partial class PackRows_Float4x4 : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,UnityEngine.Matrix4x4>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> Row0;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> Row1;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> Row2;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector4> Row3;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Row0", Row0.ToResoniteReference(context));
members.Add("Row1", Row1.ToResoniteReference(context));
members.Add("Row2", Row2.ToResoniteReference(context));
members.Add("Row3", Row3.ToResoniteReference(context));
}

}
}
