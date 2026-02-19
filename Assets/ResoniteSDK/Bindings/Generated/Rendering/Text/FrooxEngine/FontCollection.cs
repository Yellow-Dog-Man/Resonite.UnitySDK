
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FontCollection
// Generated on: čtvrtek 19. února 2026 8:00:21
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FontCollection")]
public partial class FontCollection : global::FrooxEngine.DynamicAssetProvider<global::FrooxEngine.FontSet>

{
    public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet>> FontSets;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FontSets", new ResoniteLink.SyncList()
{
    Elements = FontSets.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
