
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxInputProxy
// Generated on: úterý 24. února 2026 18:20:27
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxInputProxy")]
public partial class ProtoFluxInputProxy : global::FrooxEngine.ProtoFlux.ProtoFluxWireProxy<global::FrooxEngine.ProtoFlux.INodeOutput,global::FrooxEngine.ProtoFlux.ProtoFluxOutputProxy>

{
    public global::FrooxEngine.ISyncRef NodeInput;
public System.String InputType;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NodeInput", NodeInput.ToResoniteReference(context));
members.Add("InputType", InputType.ToResoniteLinkField());
}

}
}
