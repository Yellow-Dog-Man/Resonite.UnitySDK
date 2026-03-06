
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.Visuals.ProtoFluxOperationListManager
// Generated on: pátek 6. března 2026 14:19:10
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Visuals
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.Visuals.ProtoFluxOperationListManager")]
public partial class ProtoFluxOperationListManager : global::FrooxEngine.ProtoFlux.ProtoFluxDynamicElementManager

{
    public global::System.Boolean SupportsAsync { get => SupportsAsync_Element.Data; set => SupportsAsync_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SupportsAsync_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SupportsAsync", SupportsAsync_Element.ToLinkField(context));
}

}
}
