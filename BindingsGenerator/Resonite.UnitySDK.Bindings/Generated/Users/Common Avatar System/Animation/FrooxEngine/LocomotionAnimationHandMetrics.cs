
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionAnimationHandMetrics
// Generated on: čtvrtek 26. února 2026 15:09:16
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionAnimationHandMetrics")]
public partial class LocomotionAnimationHandMetrics : global::FrooxEngine.LocomotionAnimationParametersBase

{
    public global::FrooxEngine.LocomotionMetricsSpace Space { get => Space_Element.Data; set => Space_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.LocomotionMetricsSpace>, global::FrooxEngine.LocomotionMetricsSpace> Space_Element = new();
public global::System.Nullable<global::System.Single> ShoulderSeparation { get => ShoulderSeparation_Element.Data; set => ShoulderSeparation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> ShoulderSeparation_Element = new();
public global::System.Nullable<global::System.Single> ShoulderHeight { get => ShoulderHeight_Element.Data; set => ShoulderHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> ShoulderHeight_Element = new();
public global::System.Nullable<global::System.Single> ShoulderOffset { get => ShoulderOffset_Element.Data; set => ShoulderOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> ShoulderOffset_Element = new();
public global::System.Nullable<global::System.Single> HandOffset { get => HandOffset_Element.Data; set => HandOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> HandOffset_Element = new();
public global::System.Nullable<global::System.Single> ArmLength { get => ArmLength_Element.Data; set => ArmLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> ArmLength_Element = new();
public global::System.Nullable<global::System.Single> HandPalmDistance { get => HandPalmDistance_Element.Data; set => HandPalmDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> HandPalmDistance_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Space", Space_Element.ToLinkField(context));
members.Add("ShoulderSeparation", ShoulderSeparation_Element.ToLinkField(context));
members.Add("ShoulderHeight", ShoulderHeight_Element.ToLinkField(context));
members.Add("ShoulderOffset", ShoulderOffset_Element.ToLinkField(context));
members.Add("HandOffset", HandOffset_Element.ToLinkField(context));
members.Add("ArmLength", ArmLength_Element.ToLinkField(context));
members.Add("HandPalmDistance", HandPalmDistance_Element.ToLinkField(context));
}

}
}
