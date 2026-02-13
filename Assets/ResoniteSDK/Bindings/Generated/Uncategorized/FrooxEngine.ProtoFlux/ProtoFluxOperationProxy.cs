
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxOperationProxy
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxOperationProxy")]
public partial class ProtoFluxOperationProxy : global::FrooxEngine.ProtoFlux.ProtoFluxElementProxy

{
    public global::FrooxEngine.ProtoFlux.INodeOperation NodeOperation;
public global::System.Boolean IsAsync;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("NodeOperation", new ResoniteLink.Reference() { });
members.Add("IsAsync", IsAsync.ToResoniteLinkField());
}

}
}
