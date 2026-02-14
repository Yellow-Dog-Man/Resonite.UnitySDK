
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SkinnedMeshEmitter
// Generated on: sobota 14. února 2026 8:58:34
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
