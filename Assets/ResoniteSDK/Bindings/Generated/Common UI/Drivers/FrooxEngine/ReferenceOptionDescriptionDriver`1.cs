
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceOptionDescriptionDriver<>
// Generated on: pátek 13. února 2026 5:51:11
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Reference", new ResoniteLink.Reference() { });
members.Add("ForceDeselected", ForceDeselected.ToResoniteLinkField());
members.Add("Label", new ResoniteLink.Reference() { });
members.Add("Color", new ResoniteLink.Reference() { });
members.Add("Sprite", new ResoniteLink.Reference() { });
members.Add("DefaultOption", new ResoniteLink.SyncObject() { Members = DefaultOption.CollectMembers() });
members.Add("Options", new ResoniteLink.SyncList()
{
    Elements = Options.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
}

}
}
