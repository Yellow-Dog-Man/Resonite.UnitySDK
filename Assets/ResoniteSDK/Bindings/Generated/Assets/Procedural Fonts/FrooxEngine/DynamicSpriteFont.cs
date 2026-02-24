
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicSpriteFont
// Generated on: úterý 24. února 2026 18:17:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicSpriteFont")]
public partial class DynamicSpriteFont : global::FrooxEngine.ProceduralFont

{
    public global::System.Int32 MaxSize;
public System.Collections.Generic.List<global::FrooxEngine.DynamicSpriteFont.SpriteGlyph> Glyphs;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxSize", MaxSize.ToResoniteLinkField());
members.Add("Glyphs", new ResoniteLink.SyncList()
{
    Elements = Glyphs.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
