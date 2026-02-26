
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicSpriteFont+SpriteGlyph
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
    public partial class DynamicSpriteFont
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicSpriteFont+SpriteGlyph")]
public partial class SpriteGlyph : global::FrooxEngine.SyncObject

{
    public System.Uri SpriteURL { get => SpriteURL_Element.Data; set => SpriteURL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> SpriteURL_Element = new();
public global::System.UInt32 UnicodeCodepoint { get => UnicodeCodepoint_Element.Data; set => UnicodeCodepoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.UInt32>, global::System.UInt32> UnicodeCodepoint_Element = new();
public global::System.String SpriteName { get => SpriteName_Element.Data; set => SpriteName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SpriteName_Element = new();
public UnityEngine.Vector2 Bearing { get => Bearing_Element.Data; set => Bearing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Bearing_Element = new();
public UnityEngine.Vector2 Advance { get => Advance_Element.Data; set => Advance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Advance_Element = new();
public global::System.Single Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Size_Element = new();
public global::System.Boolean Tintable { get => Tintable_Element.Data; set => Tintable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Tintable_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpriteURL", SpriteURL_Element.Data.ToResoniteLinkField());
members.Add("UnicodeCodepoint", UnicodeCodepoint_Element.Data.ToResoniteLinkField());
members.Add("SpriteName", SpriteName_Element.Data.ToResoniteLinkField());
members.Add("Bearing", Bearing_Element.Data.ToResoniteLinkField());
members.Add("Advance", Advance_Element.Data.ToResoniteLinkField());
members.Add("Size", Size_Element.Data.ToResoniteLinkField());
members.Add("Tintable", Tintable_Element.Data.ToResoniteLinkField());
}

}
            }
}
