
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceOptionDescriptionDriver<>
// Generated on: středa 25. února 2026 16:13:07
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
    public global::FrooxEngine.SyncRef<T> Reference;
public global::System.Boolean ForceDeselected;
public global::FrooxEngine.IField<global::System.String> Label;
public global::FrooxEngine.IField<UnityEngine.ColorX> Color;
public global::FrooxEngine.SyncRef<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite>> Sprite;
public global::FrooxEngine.ReferenceOptionDescriptionDriver<T>.Option DefaultOption;
public System.Collections.Generic.List<global::FrooxEngine.ReferenceOptionDescriptionDriver<T>.Option> Options;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference.ToResoniteReference(context));
members.Add("ForceDeselected", ForceDeselected.ToResoniteLinkField());
members.Add("Label", Label.ToResoniteReference(context));
members.Add("Color", Color.ToResoniteReference(context));
members.Add("Sprite", Sprite.ToResoniteReference(context));
members.Add("DefaultOption", new ResoniteLink.SyncObject() { Members = DefaultOption.CollectMembers(context) });
members.Add("Options", new ResoniteLink.SyncList()
{
    Elements = Options.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
