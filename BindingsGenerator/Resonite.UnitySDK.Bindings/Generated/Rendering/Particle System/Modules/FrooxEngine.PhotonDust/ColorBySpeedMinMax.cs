
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedMinMax
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedMinMax")]
public partial class ColorBySpeedMinMax : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single MinSpeed { get => MinSpeed_Element.Data; set => MinSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinSpeed_Element = new();
public global::System.Single MaxSpeed { get => MaxSpeed_Element.Data; set => MaxSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSpeed_Element = new();
public UnityEngine.ColorX MinColor { get => MinColor_Element.Data; set => MinColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> MinColor_Element = new();
public UnityEngine.ColorX MaxColor { get => MaxColor_Element.Data; set => MaxColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> MaxColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinSpeed", MinSpeed_Element.ToLinkField(context));
members.Add("MaxSpeed", MaxSpeed_Element.ToLinkField(context));
members.Add("MinColor", MinColor_Element.ToLinkField(context));
members.Add("MaxColor", MaxColor_Element.ToLinkField(context));
}

}
}
