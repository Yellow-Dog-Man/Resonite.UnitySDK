
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LimbHapticPointMapper<>
// Generated on: čtvrtek 26. února 2026 10:03:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LimbHapticPointMapper<>")]
public abstract partial class LimbHapticPointMapper<T> : global::FrooxEngine.BoneChainHapticPointMapper
	where T : global::FrooxEngine.HapticPointPosition, global::FrooxEngine.ILimbHapticPosition

{
    public global::Renderite.Shared.Chirality Side { get => Side_Element.Data; set => Side_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> Side_Element = new();
public UnityEngine.Vector3 UpAxis { get => UpAxis_Element.Data; set => UpAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> UpAxis_Element = new();
public UnityEngine.Vector3 ForwardAxis { get => ForwardAxis_Element.Data; set => ForwardAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ForwardAxis_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Side", Side_Element.Data.ToResoniteLinkField());
members.Add("UpAxis", UpAxis_Element.Data.ToResoniteLinkField());
members.Add("ForwardAxis", ForwardAxis_Element.Data.ToResoniteLinkField());
}

}
}
