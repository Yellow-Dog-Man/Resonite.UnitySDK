
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueOptionDescriptionDriver<>+Option
// Generated on: čtvrtek 19. února 2026 7:58:56
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
    public partial class ValueOptionDescriptionDriver<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueOptionDescriptionDriver<>+Option")]
public partial class Option : global::FrooxEngine.SyncObject

{
    public T ReferenceValue;
public global::System.String Label;
public UnityEngine.ColorX Color;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> Sprite;
public UnityEngine.ColorX SpriteTint;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceValue", ReferenceValue.ToResoniteLinkField());
members.Add("Label", Label.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Sprite", Sprite.ToResoniteReference(context));
members.Add("SpriteTint", SpriteTint.ToResoniteLinkField());
}

}
            }
}
