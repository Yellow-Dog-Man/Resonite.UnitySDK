
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxInputProxy
// Generated on: čtvrtek 26. února 2026 12:28:13
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::FrooxEngine.ISyncRef NodeInput { get => NodeInput_Element.Data; set => NodeInput_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.ISyncRef>, global::FrooxEngine.ISyncRef> NodeInput_Element = new();
public System.String InputType { get => InputType_Element.Data; set => InputType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> InputType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NodeInput", NodeInput_Element.ToLinkReference(context));
members.Add("InputType", InputType_Element.ToLinkField(context));
}

}
}
