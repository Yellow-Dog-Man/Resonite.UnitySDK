
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialRelay
// Generated on: pátek 6. března 2026 14:18:05
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>>, global::FrooxEngine.AssetRef<global::FrooxEngine.Material>, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AssetRef<global::FrooxEngine.Material>>, global::FrooxEngine.AssetRef<global::FrooxEngine.Material>>> MaterialRefs = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaterialRefs", MaterialRefs.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
