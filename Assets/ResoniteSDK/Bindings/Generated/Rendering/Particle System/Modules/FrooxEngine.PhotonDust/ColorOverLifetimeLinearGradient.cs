
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorOverLifetimeLinearGradient
// Generated on: pátek 13. února 2026 23:23:05
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.LinearKey<UnityEngine.ColorX>[] ColorOverLifetime;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ColorOverLifetime", ColorOverLifetime.ToResoniteLinkArray());
}

}
}
