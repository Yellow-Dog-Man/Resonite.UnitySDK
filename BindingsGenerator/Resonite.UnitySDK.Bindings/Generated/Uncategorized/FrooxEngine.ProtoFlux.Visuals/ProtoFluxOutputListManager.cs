
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.Visuals.ProtoFluxOutputListManager
// Generated on: pondělí 2. března 2026 17:53:36
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Visuals
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.Visuals.ProtoFluxOutputListManager")]
public partial class ProtoFluxOutputListManager : global::FrooxEngine.ProtoFlux.ProtoFluxDynamicElementManager

{
    public System.String OutputType { get => OutputType_Element.Data; set => OutputType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> OutputType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OutputType", OutputType_Element.ToLinkField(context));
}

}
}
