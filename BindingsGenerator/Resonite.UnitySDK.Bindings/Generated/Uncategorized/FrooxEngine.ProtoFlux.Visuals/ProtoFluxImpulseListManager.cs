
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.Visuals.ProtoFluxImpulseListManager
// Generated on: čtvrtek 26. února 2026 12:28:13
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Visuals
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.Visuals.ProtoFluxImpulseListManager")]
public partial class ProtoFluxImpulseListManager : global::FrooxEngine.ProtoFlux.ProtoFluxDynamicElementManager

{
    public global::System.Nullable<global::ProtoFlux.Core.ImpulseType> ImpulseType { get => ImpulseType_Element.Data; set => ImpulseType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::ProtoFlux.Core.ImpulseType>>, global::System.Nullable<global::ProtoFlux.Core.ImpulseType>> ImpulseType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ImpulseType", ImpulseType_Element.ToLinkField(context));
}

}
}
