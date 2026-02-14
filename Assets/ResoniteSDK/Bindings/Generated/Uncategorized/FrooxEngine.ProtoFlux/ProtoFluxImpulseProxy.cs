
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxImpulseProxy
// Generated on: sobota 14. února 2026 8:58:47
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxImpulseProxy")]
public partial class ProtoFluxImpulseProxy : global::FrooxEngine.ProtoFlux.ProtoFluxWireProxy<global::FrooxEngine.ProtoFlux.INodeOperation,global::FrooxEngine.ProtoFlux.ProtoFluxOperationProxy>

{
    public global::FrooxEngine.ISyncRef NodeImpulse;
public global::ProtoFlux.Core.ImpulseType ImpulseType;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NodeImpulse", NodeImpulse.ToResoniteReference(context));
members.Add("ImpulseType", ImpulseType.ToResoniteLinkField());
}

}
}
