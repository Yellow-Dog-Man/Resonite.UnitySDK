
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyRotationAdapter
// Generated on: pátek 13. února 2026 23:23:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyRotationAdapter")]
public partial class LegacyRotationAdapter : global::FrooxEngine.FieldAdapter<global::System.Single>

{
    public global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh> ParticleMesh;
public global::FrooxEngine.IField<global::System.Boolean> UsingStretch;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ParticleMesh", new ResoniteLink.Reference() { });
members.Add("UsingStretch", new ResoniteLink.Reference() { });
}

}
}
