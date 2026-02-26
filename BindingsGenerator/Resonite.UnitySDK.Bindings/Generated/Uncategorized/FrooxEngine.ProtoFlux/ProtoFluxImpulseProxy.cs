
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxImpulseProxy
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxImpulseProxy")]
public partial class ProtoFluxImpulseProxy : global::FrooxEngine.ProtoFlux.ProtoFluxWireProxy<global::FrooxEngine.ProtoFlux.INodeOperation,global::FrooxEngine.ProtoFlux.ProtoFluxOperationProxy>

{
    public global::FrooxEngine.ISyncRef NodeImpulse { get => NodeImpulse_Element.Data; set => NodeImpulse_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.ISyncRef>, global::FrooxEngine.ISyncRef> NodeImpulse_Element = new();
public global::ProtoFlux.Core.ImpulseType ImpulseType { get => ImpulseType_Element.Data; set => ImpulseType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::ProtoFlux.Core.ImpulseType>, global::ProtoFlux.Core.ImpulseType> ImpulseType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NodeImpulse", NodeImpulse_Element.Data.ToResoniteReference(context));
members.Add("ImpulseType", ImpulseType_Element.Data.ToResoniteLinkField());
}

}
}
