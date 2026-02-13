
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxRefProxy
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxRefProxy")]
public abstract partial class ProtoFluxRefProxy : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.ProtoFluxNode Node;
public global::System.String ElementName;
public System.String ValueType;
public global::FrooxEngine.IField<global::System.String> _label;
public global::FrooxEngine.UIX.Button _proxyVisual;
public global::FrooxEngine.ReferenceProxySource _refProxySource;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Node", new ResoniteLink.Reference() { });
members.Add("ElementName", ElementName.ToResoniteLinkField());
members.Add("ValueType", ValueType.ToResoniteLinkField());
members.Add("_label", new ResoniteLink.Reference() { });
members.Add("_proxyVisual", new ResoniteLink.Reference() { });
members.Add("_refProxySource", new ResoniteLink.Reference() { });
}

}
}
