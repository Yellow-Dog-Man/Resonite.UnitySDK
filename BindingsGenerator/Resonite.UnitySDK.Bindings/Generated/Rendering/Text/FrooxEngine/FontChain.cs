
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FontChain
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FontChain")]
public partial class FontChain : global::FrooxEngine.DynamicAssetProvider<global::FrooxEngine.FontSet>

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Font> MainFont;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Font>> FallbackFonts;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MainFont", MainFont.ToResoniteReference(context));
members.Add("FallbackFonts", new ResoniteLink.SyncList()
{
    Elements = FallbackFonts.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
