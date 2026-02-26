
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceOptionDescriptionDriver<>
// Generated on: čtvrtek 26. února 2026 10:03:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceOptionDescriptionDriver<>")]
public partial class ReferenceOptionDescriptionDriver<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.SyncRef<T>>, global::FrooxEngine.SyncRef<T>> Reference_Element = new();
public global::System.Boolean ForceDeselected { get => ForceDeselected_Element.Data; set => ForceDeselected_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceDeselected_Element = new();
public global::FrooxEngine.IField<global::System.String> Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> Label_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> Color_Element = new();
public global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>> Sprite { get => Sprite_Element.Data; set => Sprite_Element.Data = value; }
public Field<global::FrooxEngine.RefDrive<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>>> Sprite_Element = new();
public global::FrooxEngine.ReferenceOptionDescriptionDriver<T>.Option DefaultOption = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ReferenceOptionDescriptionDriver<T>.Option>, global::FrooxEngine.ReferenceOptionDescriptionDriver<T>.Option> Options = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference_Element.Data.ToResoniteReference(context));
members.Add("ForceDeselected", ForceDeselected_Element.Data.ToResoniteLinkField());
members.Add("Label", Label_Element.Data.ToResoniteReference(context));
members.Add("Color", Color_Element.Data.ToResoniteReference(context));
members.Add("Sprite", Sprite_Element.Data.ToResoniteReference(context));
members.Add("DefaultOption", new ResoniteLink.SyncObject() { Members = DefaultOption.CollectMembers(context) });
members.Add("Options", new ResoniteLink.SyncList()
{
    Elements = Options.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
