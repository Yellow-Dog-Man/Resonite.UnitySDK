
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxRefProxy
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxRefProxy")]
public abstract partial class ProtoFluxRefProxy : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.ProtoFluxNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ProtoFluxNode>, global::FrooxEngine.ProtoFlux.ProtoFluxNode> Node_Element = new();
public global::System.String ElementName { get => ElementName_Element.Data; set => ElementName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ElementName_Element = new();
public System.String ValueType { get => ValueType_Element.Data; set => ValueType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> ValueType_Element = new();
public global::FrooxEngine.IField<global::System.String> _label { get => _label_Element.Data; set => _label_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _label_Element = new();
public global::FrooxEngine.UIX.Button _proxyVisual { get => _proxyVisual_Element.Data; set => _proxyVisual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _proxyVisual_Element = new();
public global::FrooxEngine.ReferenceProxySource _refProxySource { get => _refProxySource_Element.Data; set => _refProxySource_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.ReferenceProxySource>, global::FrooxEngine.ReferenceProxySource> _refProxySource_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.Data.ToResoniteReference(context));
members.Add("ElementName", ElementName_Element.Data.ToResoniteLinkField());
members.Add("ValueType", ValueType_Element.Data.ToResoniteLinkField());
members.Add("_label", _label_Element.Data.ToResoniteReference(context));
members.Add("_proxyVisual", _proxyVisual_Element.Data.ToResoniteReference(context));
members.Add("_refProxySource", _refProxySource_Element.Data.ToResoniteReference(context));
}

}
}
