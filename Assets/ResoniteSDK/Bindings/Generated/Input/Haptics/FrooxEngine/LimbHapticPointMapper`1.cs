
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LimbHapticPointMapper<>
// Generated on: pátek 13. února 2026 23:21:40
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LimbHapticPointMapper<>")]
public abstract partial class LimbHapticPointMapper<T> : global::FrooxEngine.BoneChainHapticPointMapper
	where T : global::FrooxEngine.HapticPointPosition, global::FrooxEngine.ILimbHapticPosition

{
    public global::Renderite.Shared.Chirality Side;
public UnityEngine.Vector3 UpAxis;
public UnityEngine.Vector3 ForwardAxis;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Side", Side.ToResoniteLinkField());
members.Add("UpAxis", UpAxis.ToResoniteLinkField());
members.Add("ForwardAxis", ForwardAxis.ToResoniteLinkField());
}

}
}
