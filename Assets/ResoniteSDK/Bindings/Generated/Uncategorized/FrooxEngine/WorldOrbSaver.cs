
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldOrbSaver
// Generated on: sobota 14. února 2026 8:58:49
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldOrbSaver")]
public partial class WorldOrbSaver : global::FrooxEngine.Component

{
    public global::FrooxEngine.WorldOrb Orb;
public global::FrooxEngine.ContextMenuItem saveHereItem;
public global::FrooxEngine.ContextMenuItem saveToInventoryItem;
public global::FrooxEngine.ContextMenuItem cancelItem;
public global::FrooxEngine.ContextMenu menu;
public global::System.Boolean interactive;
public global::System.Boolean saving;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Orb", Orb.ToResoniteReference(context));
members.Add("saveHereItem", saveHereItem.ToResoniteReference(context));
members.Add("saveToInventoryItem", saveToInventoryItem.ToResoniteReference(context));
members.Add("cancelItem", cancelItem.ToResoniteReference(context));
members.Add("menu", menu.ToResoniteReference(context));
members.Add("interactive", interactive.ToResoniteLinkField());
members.Add("saving", saving.ToResoniteLinkField());
}

}
}
