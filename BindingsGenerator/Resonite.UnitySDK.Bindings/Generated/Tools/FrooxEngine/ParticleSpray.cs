
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParticleSpray
// Generated on: čtvrtek 26. února 2026 12:28:06
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ParticleSpray")]
public partial class ParticleSpray : global::FrooxEngine.Tool

{
    public global::System.Single Rate { get => Rate_Element.Data; set => Rate_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Rate_Element = new();
public global::System.Single RateExp { get => RateExp_Element.Data; set => RateExp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RateExp_Element = new();
public global::System.Single MinSpeed { get => MinSpeed_Element.Data; set => MinSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinSpeed_Element = new();
public global::System.Single MaxSpeed { get => MaxSpeed_Element.Data; set => MaxSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxSpeed_Element = new();
public global::FrooxEngine.PhotonDust.ParticleStyle partStyle { get => partStyle_Element.Data; set => partStyle_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.ParticleStyle>, global::FrooxEngine.PhotonDust.ParticleStyle> partStyle_Element = new();
public global::FrooxEngine.PhotonDust.SpeedRangeInitializer partSpeed { get => partSpeed_Element.Data; set => partSpeed_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.SpeedRangeInitializer>, global::FrooxEngine.PhotonDust.SpeedRangeInitializer> partSpeed_Element = new();
public global::FrooxEngine.PhotonDust.ParticleEmitter partEmitter { get => partEmitter_Element.Data; set => partEmitter_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.ParticleEmitter>, global::FrooxEngine.PhotonDust.ParticleEmitter> partEmitter_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rate", Rate_Element.ToLinkField(context));
members.Add("RateExp", RateExp_Element.ToLinkField(context));
members.Add("MinSpeed", MinSpeed_Element.ToLinkField(context));
members.Add("MaxSpeed", MaxSpeed_Element.ToLinkField(context));
members.Add("partStyle", partStyle_Element.ToLinkReference(context));
members.Add("partSpeed", partSpeed_Element.ToLinkReference(context));
members.Add("partEmitter", partEmitter_Element.ToLinkReference(context));
}

}
}
