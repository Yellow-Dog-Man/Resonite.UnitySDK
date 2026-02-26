
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorListInitializer
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorListInitializer")]
public partial class ColorListInitializer : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.PhotonDust.ColorListInitializer.ColorEntry>, global::FrooxEngine.PhotonDust.ColorListInitializer.ColorEntry> Colors = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Colors", Colors.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
