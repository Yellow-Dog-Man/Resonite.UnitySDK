
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerSplayModifier
// Generated on: čtvrtek 26. února 2026 10:04:50
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FingerSplayModifier")]
public partial class FingerSplayModifier : global::FrooxEngine.FingerPoseProcessor

{
    public global::FrooxEngine.IFingerPoseSourceComponent Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent>, global::FrooxEngine.IFingerPoseSourceComponent> Source_Element = new();
public global::System.Single LeftSplayMagnitude { get => LeftSplayMagnitude_Element.Data; set => LeftSplayMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LeftSplayMagnitude_Element = new();
public global::System.Single RightSplayMagnitude { get => RightSplayMagnitude_Element.Data; set => RightSplayMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RightSplayMagnitude_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.Data.ToResoniteReference(context));
members.Add("LeftSplayMagnitude", LeftSplayMagnitude_Element.Data.ToResoniteLinkField());
members.Add("RightSplayMagnitude", RightSplayMagnitude_Element.Data.ToResoniteLinkField());
}

}
}
