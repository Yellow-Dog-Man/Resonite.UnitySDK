
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ViolentAprilFoolsExplosion
// Generated on: pátek 13. února 2026 23:23:21
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ViolentAprilFoolsExplosion")]
public partial class ViolentAprilFoolsExplosion : global::FrooxEngine.Component

{
    public global::System.Single BloatMagnitude;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _bloatingClip;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _explosionClip;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BloatMagnitude", BloatMagnitude.ToResoniteLinkField());
members.Add("_bloatingClip", new ResoniteLink.Reference() { });
members.Add("_explosionClip", new ResoniteLink.Reference() { });
}

}
}
