
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Enums.ShiftEnum<>
// Generated on: sobota 14. února 2026 8:57:57
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Enums
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Enums.ShiftEnum<>")]
public partial class ShiftEnum<E> : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Enums.EnumOperation<E>
	where E : struct, System.Enum

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Int32> Delta;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Delta", Delta.ToResoniteReference(context));
}

}
}
