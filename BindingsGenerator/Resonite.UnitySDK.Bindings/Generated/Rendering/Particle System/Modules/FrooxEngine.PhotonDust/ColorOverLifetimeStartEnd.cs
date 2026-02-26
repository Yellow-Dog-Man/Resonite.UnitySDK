
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorOverLifetimeStartEnd
// Generated on: čtvrtek 26. února 2026 12:28:04
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorOverLifetimeStartEnd")]
public partial class ColorOverLifetimeStartEnd : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public UnityEngine.ColorX StartColor { get => StartColor_Element.Data; set => StartColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> StartColor_Element = new();
public UnityEngine.ColorX EndColor { get => EndColor_Element.Data; set => EndColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EndColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StartColor", StartColor_Element.ToLinkField(context));
members.Add("EndColor", EndColor_Element.ToLinkField(context));
}

}
}
