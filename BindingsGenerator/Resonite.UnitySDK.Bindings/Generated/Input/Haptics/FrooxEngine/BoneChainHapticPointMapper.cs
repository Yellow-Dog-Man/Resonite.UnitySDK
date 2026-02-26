
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BoneChainHapticPointMapper
// Generated on: čtvrtek 26. února 2026 10:03:39
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
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> BoneChain = new();
public global::System.Single NormalizedStart { get => NormalizedStart_Element.Data; set => NormalizedStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalizedStart_Element = new();
public global::System.Single NormalizedEnd { get => NormalizedEnd_Element.Data; set => NormalizedEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalizedEnd_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BoneChain", new ResoniteLink.SyncList()
{
    Elements = BoneChain.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("NormalizedStart", NormalizedStart_Element.Data.ToResoniteLinkField());
members.Add("NormalizedEnd", NormalizedEnd_Element.Data.ToResoniteLinkField());
}

}
}
