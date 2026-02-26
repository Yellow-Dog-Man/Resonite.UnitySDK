
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorHSV_OverLifetimeStartEnd
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorHSV_OverLifetimeStartEnd")]
public partial class ColorHSV_OverLifetimeStartEnd : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::System.Single StartHue { get => StartHue_Element.Data; set => StartHue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartHue_Element = new();
public global::System.Single StartSaturation { get => StartSaturation_Element.Data; set => StartSaturation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartSaturation_Element = new();
public global::System.Single StartValue { get => StartValue_Element.Data; set => StartValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartValue_Element = new();
public global::System.Single EndHue { get => EndHue_Element.Data; set => EndHue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndHue_Element = new();
public global::System.Single EndSaturation { get => EndSaturation_Element.Data; set => EndSaturation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndSaturation_Element = new();
public global::System.Single EndValue { get => EndValue_Element.Data; set => EndValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("StartHue", StartHue_Element.ToLinkField(context));
members.Add("StartSaturation", StartSaturation_Element.ToLinkField(context));
members.Add("StartValue", StartValue_Element.ToLinkField(context));
members.Add("EndHue", EndHue_Element.ToLinkField(context));
members.Add("EndSaturation", EndSaturation_Element.ToLinkField(context));
members.Add("EndValue", EndValue_Element.ToLinkField(context));
}

}
}
