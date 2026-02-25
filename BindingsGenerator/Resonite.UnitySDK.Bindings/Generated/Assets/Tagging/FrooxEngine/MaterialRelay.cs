
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialRelay
// Generated on: středa 25. února 2026 16:13:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MaterialRelay")]
public partial class MaterialRelay : global::FrooxEngine.Component, global::FrooxEngine.IMaterialTarget, global::FrooxEngine.IMaterialSource

{
    public System.Collections.Generic.List<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>> MaterialRefs;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaterialRefs", new ResoniteLink.SyncList()
{
    Elements = MaterialRefs.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
