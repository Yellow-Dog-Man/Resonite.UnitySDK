
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SkinnedMeshEmitter
// Generated on: úterý 24. února 2026 18:20:07
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SkinnedMeshEmitter")]
public partial class SkinnedMeshEmitter : global::FrooxEngine.PhotonDust.MeshEmitterBase<global::System.Object>

{
    public global::FrooxEngine.SkinnedMeshRenderer Skin;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Skin", Skin.ToResoniteReference(context));
}

}
}
