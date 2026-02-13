
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ParticleStyle
// Generated on: pátek 13. února 2026 23:23:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ParticleStyle")]
public partial class ParticleStyle : global::FrooxEngine.Component

{
    public global::FrooxEngine.PhotonDust.IParticleRenderer Renderer;
public System.Collections.Generic.List<global::FrooxEngine.PhotonDust.IParticleSystemSubsystem> Modules;
public global::System.Boolean UseSystemLocalScale;
public global::PhotonDust.ScaleMultiplierMode ParticleScaleMode;
public global::System.Boolean UseSystemLocalRotation;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Renderer", new ResoniteLink.Reference() { });
members.Add("Modules", new ResoniteLink.SyncList()
{
    Elements = Modules.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("UseSystemLocalScale", UseSystemLocalScale.ToResoniteLinkField());
members.Add("ParticleScaleMode", ParticleScaleMode.ToResoniteLinkField());
members.Add("UseSystemLocalRotation", UseSystemLocalRotation.ToResoniteLinkField());
}

}
}
