
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxImpulseProxy
// Generated on: pátek 13. února 2026 23:23:17
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("NodeImpulse", new ResoniteLink.Reference() { });
members.Add("ImpulseType", ImpulseType.ToResoniteLinkField());
}

}
}
