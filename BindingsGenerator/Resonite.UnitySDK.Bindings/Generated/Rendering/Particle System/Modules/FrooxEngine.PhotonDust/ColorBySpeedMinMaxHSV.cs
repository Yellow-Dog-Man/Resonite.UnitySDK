
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedMinMaxHSV
// Generated on: čtvrtek 26. února 2026 15:09:04
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorBySpeedMinMaxHSV")]
public partial class ColorBySpeedMinMaxHSV : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single MinSpeed { get => MinSpeed_Element.Data; set => MinSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinSpeed_Element = new();
public global::System.Single MaxSpeed { get => MaxSpeed_Element.Data; set => MaxSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSpeed_Element = new();
public global::System.Single MinHue { get => MinHue_Element.Data; set => MinHue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinHue_Element = new();
public global::System.Single MaxHue { get => MaxHue_Element.Data; set => MaxHue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxHue_Element = new();
public global::System.Single MinSaturation { get => MinSaturation_Element.Data; set => MinSaturation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinSaturation_Element = new();
public global::System.Single MaxSaturation { get => MaxSaturation_Element.Data; set => MaxSaturation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSaturation_Element = new();
public global::System.Single MinValue { get => MinValue_Element.Data; set => MinValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinValue_Element = new();
public global::System.Single MaxValue { get => MaxValue_Element.Data; set => MaxValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinSpeed", MinSpeed_Element.ToLinkField(context));
members.Add("MaxSpeed", MaxSpeed_Element.ToLinkField(context));
members.Add("MinHue", MinHue_Element.ToLinkField(context));
members.Add("MaxHue", MaxHue_Element.ToLinkField(context));
members.Add("MinSaturation", MinSaturation_Element.ToLinkField(context));
members.Add("MaxSaturation", MaxSaturation_Element.ToLinkField(context));
members.Add("MinValue", MinValue_Element.ToLinkField(context));
members.Add("MaxValue", MaxValue_Element.ToLinkField(context));
}

}
}
