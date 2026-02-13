
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FontChain
// Generated on: pátek 13. února 2026 23:23:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FontChain")]
public partial class FontChain : global::FrooxEngine.DynamicAssetProvider<global::FrooxEngine.FontSet>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Font> MainFont;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Font>> FallbackFonts;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("MainFont", new ResoniteLink.Reference() { });
members.Add("FallbackFonts", new ResoniteLink.SyncList()
{
    Elements = FallbackFonts.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}
