
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicSpriteFont+SpriteGlyph
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
    public partial class DynamicSpriteFont
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicSpriteFont+SpriteGlyph")]
public partial class SpriteGlyph : global::FrooxEngine.SyncObject

{
    public System.Uri SpriteURL;
public global::System.UInt32 UnicodeCodepoint;
public global::System.String SpriteName;
public UnityEngine.Vector2 Bearing;
public UnityEngine.Vector2 Advance;
public global::System.Single Size;
public global::System.Boolean Tintable;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpriteURL", SpriteURL.ToResoniteLinkField());
members.Add("UnicodeCodepoint", UnicodeCodepoint.ToResoniteLinkField());
members.Add("SpriteName", SpriteName.ToResoniteLinkField());
members.Add("Bearing", Bearing.ToResoniteLinkField());
members.Add("Advance", Advance.ToResoniteLinkField());
members.Add("Size", Size.ToResoniteLinkField());
members.Add("Tintable", Tintable.ToResoniteLinkField());
}

}
            }
}
