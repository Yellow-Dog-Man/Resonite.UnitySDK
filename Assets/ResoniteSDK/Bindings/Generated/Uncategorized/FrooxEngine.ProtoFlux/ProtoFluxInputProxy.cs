
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxInputProxy
// Generated on: pátek 13. února 2026 5:52:35
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("NodeInput", new ResoniteLink.Reference() { });
members.Add("InputType", InputType.ToResoniteLinkField());
}

}
}
