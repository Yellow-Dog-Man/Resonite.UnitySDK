
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoneChainHapticPointMapper
// Generated on: čtvrtek 19. února 2026 7:58:58
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoneChainHapticPointMapper")]
public abstract partial class BoneChainHapticPointMapper : global::FrooxEngine.HapticPointMapper

{
    public System.Collections.Generic.List<global::FrooxEngine.Slot> BoneChain;
public global::System.Single NormalizedStart;
public global::System.Single NormalizedEnd;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoneChain", new ResoniteLink.SyncList()
{
    Elements = BoneChain.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("NormalizedStart", NormalizedStart.ToResoniteLinkField());
members.Add("NormalizedEnd", NormalizedEnd.ToResoniteLinkField());
}

}
}
