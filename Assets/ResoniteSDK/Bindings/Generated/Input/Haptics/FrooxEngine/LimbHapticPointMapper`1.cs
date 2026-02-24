
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LimbHapticPointMapper<>
// Generated on: úterý 24. února 2026 18:17:49
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Side", Side.ToResoniteLinkField());
members.Add("UpAxis", UpAxis.ToResoniteLinkField());
members.Add("ForwardAxis", ForwardAxis.ToResoniteLinkField());
}

}
}
