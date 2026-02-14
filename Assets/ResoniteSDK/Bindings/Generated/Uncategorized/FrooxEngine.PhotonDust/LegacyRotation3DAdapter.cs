
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyRotation3DAdapter
// Generated on: sobota 14. února 2026 8:58:45
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyRotation3DAdapter")]
public partial class LegacyRotation3DAdapter : global::FrooxEngine.FieldAdapter<UnityEngine.Vector3>

{
    public global::FrooxEngine.AssetRef<global::FrooxEngine.Mesh> ParticleMesh;
public global::FrooxEngine.IField<global::System.Boolean> UsingStretch;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ParticleMesh", ParticleMesh.ToResoniteReference(context));
members.Add("UsingStretch", UsingStretch.ToResoniteReference(context));
}

}
}
