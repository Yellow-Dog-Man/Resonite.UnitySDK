
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RootContextMenuItem
// Generated on: úterý 24. února 2026 18:20:02
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RootContextMenuItem")]
public partial class RootContextMenuItem : global::FrooxEngine.UserRootComponent

{
    public global::System.Nullable<global::Renderite.Shared.Chirality> OnlyForSide;
public global::System.Boolean ExcludeOnTools;
public global::System.Boolean ExcludePrimaryHand;
public global::System.Boolean ExcludeSecondaryHand;
public global::FrooxEngine.ContextMenuItemSource Item;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnlyForSide", OnlyForSide.ToResoniteLinkField());
members.Add("ExcludeOnTools", ExcludeOnTools.ToResoniteLinkField());
members.Add("ExcludePrimaryHand", ExcludePrimaryHand.ToResoniteLinkField());
members.Add("ExcludeSecondaryHand", ExcludeSecondaryHand.ToResoniteLinkField());
members.Add("Item", Item.ToResoniteReference(context));
}

}
}
