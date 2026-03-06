
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.RangeValueInitializer<,>
// Generated on: pátek 6. března 2026 14:19:04
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.RangeValueInitializer<,>")]
public abstract partial class RangeValueInitializer<M,V> : global::FrooxEngine.PhotonDust.ParticleSystemModule<M>
	where V : struct
	

{
    public V MinValue { get => MinValue_Element.Data; set => MinValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<V>, V> MinValue_Element = new();
public V MaxValue { get => MaxValue_Element.Data; set => MaxValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<V>, V> MaxValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinValue", MinValue_Element.ToLinkField(context));
members.Add("MaxValue", MaxValue_Element.ToLinkField(context));
}

}
}
