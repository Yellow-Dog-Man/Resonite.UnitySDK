
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.Visuals.ProtoFluxImpulseListManager
// Generated on: pátek 13. února 2026 5:52:35
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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
    public global::System.Nullable<global::ProtoFlux.Core.ImpulseType> ImpulseType;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ImpulseType", ImpulseType.ToResoniteLinkField());
}

}
}
