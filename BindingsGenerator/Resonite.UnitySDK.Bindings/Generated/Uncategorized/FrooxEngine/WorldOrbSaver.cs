
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldOrbSaver
// Generated on: čtvrtek 26. února 2026 12:28:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldOrbSaver")]
public partial class WorldOrbSaver : global::FrooxEngine.Component

{
    public global::FrooxEngine.WorldOrb Orb { get => Orb_Element.Data; set => Orb_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldOrb>, global::FrooxEngine.WorldOrb> Orb_Element = new();
public global::FrooxEngine.ContextMenuItem saveHereItem { get => saveHereItem_Element.Data; set => saveHereItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ContextMenuItem>, global::FrooxEngine.ContextMenuItem> saveHereItem_Element = new();
public global::FrooxEngine.ContextMenuItem saveToInventoryItem { get => saveToInventoryItem_Element.Data; set => saveToInventoryItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ContextMenuItem>, global::FrooxEngine.ContextMenuItem> saveToInventoryItem_Element = new();
public global::FrooxEngine.ContextMenuItem cancelItem { get => cancelItem_Element.Data; set => cancelItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ContextMenuItem>, global::FrooxEngine.ContextMenuItem> cancelItem_Element = new();
public global::FrooxEngine.ContextMenu menu { get => menu_Element.Data; set => menu_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ContextMenu>, global::FrooxEngine.ContextMenu> menu_Element = new();
public global::System.Boolean interactive { get => interactive_Element.Data; set => interactive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> interactive_Element = new();
public global::System.Boolean saving { get => saving_Element.Data; set => saving_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> saving_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Orb", Orb_Element.ToLinkReference(context));
members.Add("saveHereItem", saveHereItem_Element.ToLinkReference(context));
members.Add("saveToInventoryItem", saveToInventoryItem_Element.ToLinkReference(context));
members.Add("cancelItem", cancelItem_Element.ToLinkReference(context));
members.Add("menu", menu_Element.ToLinkReference(context));
members.Add("interactive", interactive_Element.ToLinkField(context));
members.Add("saving", saving_Element.ToLinkField(context));
}

}
}
