
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ViolentAprilFoolsExplosion
// Generated on: sobota 14. února 2026 8:58:51
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BloatMagnitude", BloatMagnitude.ToResoniteLinkField());
members.Add("_bloatingClip", _bloatingClip.ToResoniteReference(context));
members.Add("_explosionClip", _explosionClip.ToResoniteReference(context));
}

}
}
