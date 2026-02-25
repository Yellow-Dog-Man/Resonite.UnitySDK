
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticPointSampler
// Generated on: středa 25. února 2026 16:13:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticPointSampler")]
public partial class HapticPointSampler : global::FrooxEngine.HapticPointSamplerBase

{
    public global::FrooxEngine.UserRef SamplingUser;
public global::System.Int32 HapticPointIndex;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SamplingUser", new ResoniteLink.SyncObject() { Members = SamplingUser.CollectMembers(context) });
members.Add("HapticPointIndex", HapticPointIndex.ToResoniteLinkField());
}

}
}
