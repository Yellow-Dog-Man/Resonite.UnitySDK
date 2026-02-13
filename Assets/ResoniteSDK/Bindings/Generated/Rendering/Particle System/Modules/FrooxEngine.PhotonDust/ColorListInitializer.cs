
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorListInitializer
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorListInitializer")]
public partial class ColorListInitializer : global::FrooxEngine.PhotonDust.ParticleSystemModule<global::System.Object>

{
    public System.Collections.Generic.List<global::FrooxEngine.PhotonDust.ColorListInitializer.ColorEntry> Colors;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Colors", new ResoniteLink.SyncList()
{
    Elements = Colors.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
