
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RootContextMenuItem
// Generated on: čtvrtek 26. února 2026 10:04:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RootContextMenuItem")]
public partial class RootContextMenuItem : global::FrooxEngine.UserRootComponent

{
    public global::System.Nullable<global::Renderite.Shared.Chirality> OnlyForSide { get => OnlyForSide_Element.Data; set => OnlyForSide_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::Renderite.Shared.Chirality>>, global::System.Nullable<global::Renderite.Shared.Chirality>> OnlyForSide_Element = new();
public global::System.Boolean ExcludeOnTools { get => ExcludeOnTools_Element.Data; set => ExcludeOnTools_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ExcludeOnTools_Element = new();
public global::System.Boolean ExcludePrimaryHand { get => ExcludePrimaryHand_Element.Data; set => ExcludePrimaryHand_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ExcludePrimaryHand_Element = new();
public global::System.Boolean ExcludeSecondaryHand { get => ExcludeSecondaryHand_Element.Data; set => ExcludeSecondaryHand_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ExcludeSecondaryHand_Element = new();
public global::FrooxEngine.ContextMenuItemSource Item { get => Item_Element.Data; set => Item_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ContextMenuItemSource>, global::FrooxEngine.ContextMenuItemSource> Item_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnlyForSide", OnlyForSide_Element.Data.ToResoniteLinkField());
members.Add("ExcludeOnTools", ExcludeOnTools_Element.Data.ToResoniteLinkField());
members.Add("ExcludePrimaryHand", ExcludePrimaryHand_Element.Data.ToResoniteLinkField());
members.Add("ExcludeSecondaryHand", ExcludeSecondaryHand_Element.Data.ToResoniteLinkField());
members.Add("Item", Item_Element.Data.ToResoniteReference(context));
}

}
}
