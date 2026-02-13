
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyHorizontalChoiceBar
// Generated on: pátek 13. února 2026 5:52:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyHorizontalChoiceBar")]
public partial class LegacyHorizontalChoiceBar : global::FrooxEngine.LegacyUIElement

{
    public System.Collections.Generic.List<global::FrooxEngine.LegacyHorizontalChoiceBar.Item> _items;
public global::System.Single Width;
public global::System.Single Height;
public global::System.Single Thickness;
public global::System.Single Spacing;
public global::System.Single Slant;
public global::System.Boolean Symmetrical;
public global::FrooxEngine.Slot _root;
public global::FrooxEngine.IField<UnityEngine.Vector3> _rootScale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_items", new ResoniteLink.SyncList()
{
    Elements = _items.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("Width", Width.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("Spacing", Spacing.ToResoniteLinkField());
members.Add("Slant", Slant.ToResoniteLinkField());
members.Add("Symmetrical", Symmetrical.ToResoniteLinkField());
members.Add("_root", new ResoniteLink.Reference() { });
members.Add("_rootScale", new ResoniteLink.Reference() { });
}

}
}
