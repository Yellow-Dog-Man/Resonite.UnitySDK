
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxElementProxy
// Generated on: čtvrtek 26. února 2026 10:04:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxElementProxy")]
public abstract partial class ProtoFluxElementProxy : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.ProtoFluxNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ProtoFluxNode>, global::FrooxEngine.ProtoFlux.ProtoFluxNode> Node_Element = new();
public global::System.String ElementName { get => ElementName_Element.Data; set => ElementName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ElementName_Element = new();
public global::System.Boolean IsDynamic { get => IsDynamic_Element.Data; set => IsDynamic_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsDynamic_Element = new();
public global::System.Int32 Index { get => Index_Element.Data; set => Index_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Index_Element = new();
public global::FrooxEngine.Slot ConnectPoint { get => ConnectPoint_Element.Data; set => ConnectPoint_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ConnectPoint_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.Data.ToResoniteReference(context));
members.Add("ElementName", ElementName_Element.Data.ToResoniteLinkField());
members.Add("IsDynamic", IsDynamic_Element.Data.ToResoniteLinkField());
members.Add("Index", Index_Element.Data.ToResoniteLinkField());
members.Add("ConnectPoint", ConnectPoint_Element.Data.ToResoniteReference(context));
}

}
}
