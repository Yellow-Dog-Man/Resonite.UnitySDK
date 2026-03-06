
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorOverLifetimeLinearGradient
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorOverLifetimeLinearGradient")]
public partial class ColorOverLifetimeLinearGradient : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>, global::FrooxEngine.ICustomInspector

{
    public global::SyncArray<global::FrooxEngine.SyncLinear<UnityEngine.ColorX>, global::FrooxEngine.LinearKey<UnityEngine.ColorX>> ColorOverLifetime = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ColorOverLifetime", ColorOverLifetime.ToLinkArray(context));
}

}
}
