
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyHorizontalChoiceBar
// Generated on: čtvrtek 26. února 2026 15:09:09
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyHorizontalChoiceBar")]
public partial class LegacyHorizontalChoiceBar : global::FrooxEngine.LegacyUIElement

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LegacyHorizontalChoiceBar.Item>, global::FrooxEngine.LegacyHorizontalChoiceBar.Item> _items = new();
public global::System.Single Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Width_Element = new();
public global::System.Single Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Height_Element = new();
public global::System.Single Thickness { get => Thickness_Element.Data; set => Thickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Thickness_Element = new();
public global::System.Single Spacing { get => Spacing_Element.Data; set => Spacing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Spacing_Element = new();
public global::System.Single Slant { get => Slant_Element.Data; set => Slant_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Slant_Element = new();
public global::System.Boolean Symmetrical { get => Symmetrical_Element.Data; set => Symmetrical_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Symmetrical_Element = new();
public global::FrooxEngine.Slot _root { get => _root_Element.Data; set => _root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _root_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _rootScale { get => _rootScale_Element.Data; set => _rootScale_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _rootScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_items", _items.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("Width", Width_Element.ToLinkField(context));
members.Add("Height", Height_Element.ToLinkField(context));
members.Add("Thickness", Thickness_Element.ToLinkField(context));
members.Add("Spacing", Spacing_Element.ToLinkField(context));
members.Add("Slant", Slant_Element.ToLinkField(context));
members.Add("Symmetrical", Symmetrical_Element.ToLinkField(context));
members.Add("_root", _root_Element.ToLinkReference(context));
members.Add("_rootScale", _rootScale_Element.ToLinkReference(context));
}

}
}
