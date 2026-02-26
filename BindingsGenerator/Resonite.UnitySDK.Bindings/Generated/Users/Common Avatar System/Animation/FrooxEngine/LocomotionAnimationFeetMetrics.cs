
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationFeetMetrics
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationFeetMetrics")]
public partial class LocomotionAnimationFeetMetrics : global::FrooxEngine.LocomotionAnimationParametersBase

{
    public global::FrooxEngine.LocomotionMetricsSpace Space { get => Space_Element.Data; set => Space_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.LocomotionMetricsSpace>, global::FrooxEngine.LocomotionMetricsSpace> Space_Element = new();
public global::System.Nullable<global::System.Single> FeetSeparation { get => FeetSeparation_Element.Data; set => FeetSeparation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> FeetSeparation_Element = new();
public global::System.Nullable<global::System.Single> FeetBackwardsOffset { get => FeetBackwardsOffset_Element.Data; set => FeetBackwardsOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> FeetBackwardsOffset_Element = new();
public global::System.Nullable<global::System.Single> FootHeight { get => FootHeight_Element.Data; set => FootHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> FootHeight_Element = new();
public global::System.Nullable<global::System.Single> FootFrontOffset { get => FootFrontOffset_Element.Data; set => FootFrontOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> FootFrontOffset_Element = new();
public global::System.Nullable<global::System.Single> FootBackOffset { get => FootBackOffset_Element.Data; set => FootBackOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> FootBackOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Space", Space_Element.ToLinkField(context));
members.Add("FeetSeparation", FeetSeparation_Element.ToLinkField(context));
members.Add("FeetBackwardsOffset", FeetBackwardsOffset_Element.ToLinkField(context));
members.Add("FootHeight", FootHeight_Element.ToLinkField(context));
members.Add("FootFrontOffset", FootFrontOffset_Element.ToLinkField(context));
members.Add("FootBackOffset", FootBackOffset_Element.ToLinkField(context));
}

}
}
