
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxRefProxy
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxRefProxy")]
public abstract partial class ProtoFluxRefProxy : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.ProtoFluxNode Node;
public global::System.String ElementName;
public System.String ValueType;
public global::FrooxEngine.IField<global::System.String> _label;
public global::FrooxEngine.UIX.Button _proxyVisual;
public global::FrooxEngine.ReferenceProxySource _refProxySource;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node.ToResoniteReference(context));
members.Add("ElementName", ElementName.ToResoniteLinkField());
members.Add("ValueType", ValueType.ToResoniteLinkField());
members.Add("_label", _label.ToResoniteReference(context));
members.Add("_proxyVisual", _proxyVisual.ToResoniteReference(context));
members.Add("_refProxySource", _refProxySource.ToResoniteReference(context));
}

}
}
