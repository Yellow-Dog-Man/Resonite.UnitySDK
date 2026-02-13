
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoneChainHapticPointMapper
// Generated on: pátek 13. února 2026 23:21:40
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BoneChainHapticPointMapper")]
public abstract partial class BoneChainHapticPointMapper : global::FrooxEngine.HapticPointMapper

{
    public System.Collections.Generic.List<global::FrooxEngine.Slot> BoneChain;
public global::System.Single NormalizedStart;
public global::System.Single NormalizedEnd;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BoneChain", new ResoniteLink.SyncList()
{
    Elements = BoneChain.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("NormalizedStart", NormalizedStart.ToResoniteLinkField());
members.Add("NormalizedEnd", NormalizedEnd.ToResoniteLinkField());
}

}
}
