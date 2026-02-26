
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ViolentAprilFoolsExplosion
// Generated on: čtvrtek 26. února 2026 10:04:50
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::System.Single BloatMagnitude { get => BloatMagnitude_Element.Data; set => BloatMagnitude_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BloatMagnitude_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _bloatingClip { get => _bloatingClip_Element.Data; set => _bloatingClip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _bloatingClip_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _explosionClip { get => _explosionClip_Element.Data; set => _explosionClip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _explosionClip_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BloatMagnitude", BloatMagnitude_Element.Data.ToResoniteLinkField());
members.Add("_bloatingClip", _bloatingClip_Element.Data.ToResoniteReference(context));
members.Add("_explosionClip", _explosionClip_Element.Data.ToResoniteReference(context));
}

}
}
