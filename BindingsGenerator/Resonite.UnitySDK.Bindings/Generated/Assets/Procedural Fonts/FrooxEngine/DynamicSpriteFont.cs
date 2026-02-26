
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicSpriteFont
// Generated on: čtvrtek 26. února 2026 10:03:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicSpriteFont")]
public partial class DynamicSpriteFont : global::FrooxEngine.ProceduralFont

{
    public global::System.Int32 MaxSize { get => MaxSize_Element.Data; set => MaxSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxSize_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.DynamicSpriteFont.SpriteGlyph>, global::FrooxEngine.DynamicSpriteFont.SpriteGlyph> Glyphs = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxSize", MaxSize_Element.Data.ToResoniteLinkField());
members.Add("Glyphs", new ResoniteLink.SyncList()
{
    Elements = Glyphs.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
