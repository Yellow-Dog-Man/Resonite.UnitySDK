
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticPointSampler
// Generated on: čtvrtek 26. února 2026 12:26:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticPointSampler")]
public partial class HapticPointSampler : global::FrooxEngine.HapticPointSamplerBase

{
    public global::FrooxEngine.UserRef SamplingUser = new();
public global::System.Int32 HapticPointIndex { get => HapticPointIndex_Element.Data; set => HapticPointIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> HapticPointIndex_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SamplingUser", SamplingUser.ToLinkSyncObject(context));
members.Add("HapticPointIndex", HapticPointIndex_Element.ToLinkField(context));
}

}
}
