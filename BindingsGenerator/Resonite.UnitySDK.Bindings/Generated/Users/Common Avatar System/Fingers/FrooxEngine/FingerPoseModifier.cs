
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPoseModifier
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FingerPoseModifier")]
public partial class FingerPoseModifier : global::FrooxEngine.FingerPoseProcessor

{
    public global::FrooxEngine.IFingerPoseSourceComponent Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent>, global::FrooxEngine.IFingerPoseSourceComponent> Source_Element = new();
public global::FrooxEngine.FingerPoseModifier.FingerOffsets LeftOffsets = new();
public global::FrooxEngine.FingerPoseModifier.FingerOffsets RightOffsets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("LeftOffsets", LeftOffsets.ToLinkSyncObject(context));
members.Add("RightOffsets", RightOffsets.ToLinkSyncObject(context));
}

}
}
