
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoneChainHapticPointMapper
// Generated on: středa 25. února 2026 16:13:09
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
