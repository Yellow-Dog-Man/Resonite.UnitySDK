
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxElementProxy
// Generated on: pátek 13. února 2026 23:23:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxElementProxy")]
public abstract partial class ProtoFluxElementProxy : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.ProtoFluxNode Node;
public global::System.String ElementName;
public global::System.Boolean IsDynamic;
public global::System.Int32 Index;
public global::FrooxEngine.Slot ConnectPoint;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Node", new ResoniteLink.Reference() { });
members.Add("ElementName", ElementName.ToResoniteLinkField());
members.Add("IsDynamic", IsDynamic.ToResoniteLinkField());
members.Add("Index", Index.ToResoniteLinkField());
members.Add("ConnectPoint", new ResoniteLink.Reference() { });
}

}
}
