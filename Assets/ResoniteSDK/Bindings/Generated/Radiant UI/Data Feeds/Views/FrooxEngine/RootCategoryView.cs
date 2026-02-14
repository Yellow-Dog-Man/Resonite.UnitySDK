
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RootCategoryView
// Generated on: sobota 14. února 2026 8:58:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RootCategoryView")]
public partial class RootCategoryView : global::FrooxEngine.DataFeedViewBase, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.DataFeedItemMappingManager CategoryManager;
public global::FrooxEngine.DataFeedItemMappingManager ItemsManager;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CategoryManager", new ResoniteLink.SyncObject() { Members = CategoryManager.CollectMembers(context) });
members.Add("ItemsManager", new ResoniteLink.SyncObject() { Members = ItemsManager.CollectMembers(context) });
}

}
}
