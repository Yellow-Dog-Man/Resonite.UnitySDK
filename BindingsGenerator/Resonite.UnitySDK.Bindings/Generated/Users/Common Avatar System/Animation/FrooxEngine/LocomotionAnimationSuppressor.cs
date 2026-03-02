
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationSuppressor
// Generated on: pondělí 2. března 2026 17:53:37
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationSuppressor")]
public partial class LocomotionAnimationSuppressor : global::FrooxEngine.UserRootComponent

{
    public global::System.Boolean SuppressFeetSimulation { get => SuppressFeetSimulation_Element.Data; set => SuppressFeetSimulation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SuppressFeetSimulation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SuppressFeetSimulation", SuppressFeetSimulation_Element.ToLinkField(context));
}

}
}
