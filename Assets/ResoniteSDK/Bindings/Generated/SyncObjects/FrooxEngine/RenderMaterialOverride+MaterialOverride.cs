
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderMaterialOverride+MaterialOverride
// Generated on: čtvrtek 19. února 2026 8:00:19
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
    public partial class RenderMaterialOverride
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RenderMaterialOverride+MaterialOverride")]
public partial class MaterialOverride : global::FrooxEngine.SyncObject

{
    public global::System.Int32 Index;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Index", Index.ToResoniteLinkField());
members.Add("Material", Material.ToResoniteReference(context));
}

}
            }
}
