
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueOptionDescriptionDriver<>
// Generated on: čtvrtek 26. února 2026 12:26:53
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueOptionDescriptionDriver<>")]
public partial class ValueOptionDescriptionDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IField<T> Value { get => Value_Element.Data; set => Value_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Value_Element = new();
public global::System.Boolean ForceDeselected { get => ForceDeselected_Element.Data; set => ForceDeselected_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceDeselected_Element = new();
public global::FrooxEngine.IField<global::System.String> Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> Label_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> Color_Element = new();
public global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>> Sprite { get => Sprite_Element.Data; set => Sprite_Element.Data = value; }
public Field<global::FrooxEngine.RefDrive<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>>> Sprite_Element = new();
public global::FrooxEngine.IField<System.Uri> SpriteURL { get => SpriteURL_Element.Data; set => SpriteURL_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<System.Uri>, global::FrooxEngine.IField<System.Uri>> SpriteURL_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> SpriteTint { get => SpriteTint_Element.Data; set => SpriteTint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> SpriteTint_Element = new();
public global::FrooxEngine.ValueOptionDescriptionDriver<T>.Option DefaultOption = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ValueOptionDescriptionDriver<T>.Option>, global::FrooxEngine.ValueOptionDescriptionDriver<T>.Option> Options = new();
public UnityEngine.ColorX SpriteTintBase { get => SpriteTintBase_Element.Data; set => SpriteTintBase_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SpriteTintBase_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value_Element.ToLinkReference(context));
members.Add("ForceDeselected", ForceDeselected_Element.ToLinkField(context));
members.Add("Label", Label_Element.ToLinkReference(context));
members.Add("Color", Color_Element.ToLinkReference(context));
members.Add("Sprite", Sprite_Element.ToLinkReference(context));
members.Add("SpriteURL", SpriteURL_Element.ToLinkReference(context));
members.Add("SpriteTint", SpriteTint_Element.ToLinkReference(context));
members.Add("DefaultOption", DefaultOption.ToLinkSyncObject(context));
members.Add("Options", Options.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("SpriteTintBase", SpriteTintBase_Element.ToLinkField(context));
}

}
}
