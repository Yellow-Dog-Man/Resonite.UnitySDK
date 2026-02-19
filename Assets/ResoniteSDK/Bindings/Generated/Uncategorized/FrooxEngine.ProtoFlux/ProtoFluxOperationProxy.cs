
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxOperationProxy
// Generated on: čtvrtek 19. února 2026 8:00:30
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxOperationProxy")]
public partial class ProtoFluxOperationProxy : global::FrooxEngine.ProtoFlux.ProtoFluxElementProxy

{
    public global::FrooxEngine.ProtoFlux.INodeOperation NodeOperation;
public global::System.Boolean IsAsync;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NodeOperation", NodeOperation.ToResoniteReference(context));
members.Add("IsAsync", IsAsync.ToResoniteLinkField());
}

}
}
