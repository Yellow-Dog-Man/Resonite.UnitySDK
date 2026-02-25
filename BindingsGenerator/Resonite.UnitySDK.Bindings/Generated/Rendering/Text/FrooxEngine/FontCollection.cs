
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FontCollection
// Generated on: středa 25. února 2026 16:14:19
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
