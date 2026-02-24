
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FontCollection
// Generated on: úterý 24. února 2026 18:20:10
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
