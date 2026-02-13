
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderMaterialOverride+MaterialOverride
// Generated on: pátek 13. února 2026 5:52:21
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class RenderMaterialOverride
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RenderMaterialOverride+MaterialOverride")]
public partial class MaterialOverride : global::FrooxEngine.SyncObject

{
    public global::System.Int32 Index;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Index", Index.ToResoniteLinkField());
members.Add("Material", new ResoniteLink.Reference() { });
}

}
            }
}
