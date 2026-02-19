
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPoseLerp
// Generated on: čtvrtek 19. února 2026 8:00:33
// Resonite version: 2026.2.19.471
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FingerPoseLerp")]
public partial class FingerPoseLerp : global::FrooxEngine.FingerPoseProcessor

{
    public global::FrooxEngine.IFingerPoseSourceComponent A;
public global::FrooxEngine.IFingerPoseSourceComponent B;
public global::System.Single Lerp;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("A", A.ToResoniteReference(context));
members.Add("B", B.ToResoniteReference(context));
members.Add("Lerp", Lerp.ToResoniteLinkField());
}

}
}
