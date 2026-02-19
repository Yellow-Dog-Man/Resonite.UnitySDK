
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueOptionDescriptionDriver<>
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueOptionDescriptionDriver<>")]
public partial class ValueOptionDescriptionDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IField<T> Value;
public global::System.Boolean ForceDeselected;
public global::FrooxEngine.IField<global::System.String> Label;
public global::FrooxEngine.IField<UnityEngine.ColorX> Color;
public global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>> Sprite;
public global::FrooxEngine.IField<System.Uri> SpriteURL;
public global::FrooxEngine.IField<UnityEngine.ColorX> SpriteTint;
public global::FrooxEngine.ValueOptionDescriptionDriver<T>.Option DefaultOption;
public System.Collections.Generic.List<global::FrooxEngine.ValueOptionDescriptionDriver<T>.Option> Options;
public UnityEngine.ColorX SpriteTintBase;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToResoniteReference(context));
members.Add("ForceDeselected", ForceDeselected.ToResoniteLinkField());
members.Add("Label", Label.ToResoniteReference(context));
members.Add("Color", Color.ToResoniteReference(context));
members.Add("Sprite", Sprite.ToResoniteReference(context));
members.Add("SpriteURL", SpriteURL.ToResoniteReference(context));
members.Add("SpriteTint", SpriteTint.ToResoniteReference(context));
members.Add("DefaultOption", new ResoniteLink.SyncObject() { Members = DefaultOption.CollectMembers(context) });
members.Add("Options", new ResoniteLink.SyncList()
{
    Elements = Options.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("SpriteTintBase", SpriteTintBase.ToResoniteLinkField());
}

}
}
