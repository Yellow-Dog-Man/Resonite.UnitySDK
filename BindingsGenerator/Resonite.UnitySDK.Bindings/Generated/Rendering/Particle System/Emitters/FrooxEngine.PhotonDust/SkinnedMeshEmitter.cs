
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.SkinnedMeshEmitter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.SkinnedMeshEmitter")]
public partial class SkinnedMeshEmitter : global::FrooxEngine.PhotonDust.MeshEmitterBase<global::System.Object>

{
    public global::FrooxEngine.SkinnedMeshRenderer Skin { get => Skin_Element.Data; set => Skin_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer> Skin_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Skin", Skin_Element.ToLinkReference(context));
}

}
}
