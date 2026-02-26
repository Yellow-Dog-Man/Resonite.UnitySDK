
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LegacyAnimationTypeAdapter
// Generated on: čtvrtek 26. února 2026 15:09:12
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LegacyAnimationTypeAdapter")]
public partial class LegacyAnimationTypeAdapter : global::FrooxEngine.Component

{
    public global::FrooxEngine.PhotonDust.LegacyParticleAnimationType Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.PhotonDust.LegacyParticleAnimationType>, global::FrooxEngine.PhotonDust.LegacyParticleAnimationType> Source_Element = new();
public global::FrooxEngine.IField<global::PhotonDust.TextureSheetAnimationType> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::PhotonDust.TextureSheetAnimationType>, global::FrooxEngine.IField<global::PhotonDust.TextureSheetAnimationType>> Target_Element = new();
public global::FrooxEngine.IValue<UnityEngine.Vector2Int> AnimationTiles { get => AnimationTiles_Element.Data; set => AnimationTiles_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IValue<UnityEngine.Vector2Int>>, global::FrooxEngine.IValue<UnityEngine.Vector2Int>> AnimationTiles_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> AnimationEnabled { get => AnimationEnabled_Element.Data; set => AnimationEnabled_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> AnimationEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkField(context));
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("AnimationTiles", AnimationTiles_Element.ToLinkReference(context));
members.Add("AnimationEnabled", AnimationEnabled_Element.ToLinkReference(context));
}

}
}
