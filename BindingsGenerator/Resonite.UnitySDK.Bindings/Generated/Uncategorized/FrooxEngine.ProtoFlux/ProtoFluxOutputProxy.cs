
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxOutputProxy
// Generated on: čtvrtek 26. února 2026 10:04:47
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxOutputProxy")]
public partial class ProtoFluxOutputProxy : global::FrooxEngine.ProtoFlux.ProtoFluxElementProxy

{
    public global::FrooxEngine.ProtoFlux.INodeOutput NodeOutput { get => NodeOutput_Element.Data; set => NodeOutput_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOutput>, global::FrooxEngine.ProtoFlux.INodeOutput> NodeOutput_Element = new();
public System.String OutputType { get => OutputType_Element.Data; set => OutputType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> OutputType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NodeOutput", NodeOutput_Element.Data.ToResoniteReference(context));
members.Add("OutputType", OutputType_Element.Data.ToResoniteLinkField());
}

}
}
