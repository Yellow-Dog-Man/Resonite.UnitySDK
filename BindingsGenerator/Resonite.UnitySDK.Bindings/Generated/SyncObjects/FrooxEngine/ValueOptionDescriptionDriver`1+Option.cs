
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueOptionDescriptionDriver<>+Option
// Generated on: čtvrtek 26. února 2026 15:07:58
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public T ReferenceValue { get => ReferenceValue_Element.Data; set => ReferenceValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> ReferenceValue_Element = new();
public global::System.String Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Label_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> Sprite { get => Sprite_Element.Data; set => Sprite_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Sprite>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>> Sprite_Element = new();
public UnityEngine.ColorX SpriteTint { get => SpriteTint_Element.Data; set => SpriteTint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpriteTint_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReferenceValue", ReferenceValue_Element.ToLinkField(context));
members.Add("Label", Label_Element.ToLinkField(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("Sprite", Sprite_Element.ToLinkReference(context));
members.Add("SpriteTint", SpriteTint_Element.ToLinkField(context));
}

}
            }
}
