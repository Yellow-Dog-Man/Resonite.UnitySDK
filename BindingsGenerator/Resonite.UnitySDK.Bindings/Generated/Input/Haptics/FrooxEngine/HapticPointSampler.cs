
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticPointSampler
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
