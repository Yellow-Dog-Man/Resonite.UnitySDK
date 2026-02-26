
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleStyle
// Generated on: čtvrtek 26. února 2026 10:04:37
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleStyle")]
public partial class ParticleStyle : global::FrooxEngine.Component

{
    public global::FrooxEngine.PhotonDust.IParticleRenderer Renderer { get => Renderer_Element.Data; set => Renderer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.IParticleRenderer>, global::FrooxEngine.PhotonDust.IParticleRenderer> Renderer_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.PhotonDust.IParticleSystemSubsystem>, global::FrooxEngine.PhotonDust.IParticleSystemSubsystem, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PhotonDust.IParticleSystemSubsystem>, global::FrooxEngine.PhotonDust.IParticleSystemSubsystem>> Modules = new();
public global::System.Boolean UseSystemLocalScale { get => UseSystemLocalScale_Element.Data; set => UseSystemLocalScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSystemLocalScale_Element = new();
public global::PhotonDust.ScaleMultiplierMode ParticleScaleMode { get => ParticleScaleMode_Element.Data; set => ParticleScaleMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.ScaleMultiplierMode>, global::PhotonDust.ScaleMultiplierMode> ParticleScaleMode_Element = new();
public global::System.Boolean UseSystemLocalRotation { get => UseSystemLocalRotation_Element.Data; set => UseSystemLocalRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseSystemLocalRotation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Renderer", Renderer_Element.Data.ToResoniteReference(context));
members.Add("Modules", new ResoniteLink.SyncList()
{
    Elements = Modules.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("UseSystemLocalScale", UseSystemLocalScale_Element.Data.ToResoniteLinkField());
members.Add("ParticleScaleMode", ParticleScaleMode_Element.Data.ToResoniteLinkField());
members.Add("UseSystemLocalRotation", UseSystemLocalRotation_Element.Data.ToResoniteLinkField());
}

}
}
