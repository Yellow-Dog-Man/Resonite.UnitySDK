
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialRelay
// Generated on: pátek 13. února 2026 23:21:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MaterialRelay")]
public partial class MaterialRelay : global::FrooxEngine.Component, global::FrooxEngine.IMaterialTarget, global::FrooxEngine.IMaterialSource

{
    public System.Collections.Generic.List<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>> MaterialRefs;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MaterialRefs", new ResoniteLink.SyncList()
{
    Elements = MaterialRefs.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}
