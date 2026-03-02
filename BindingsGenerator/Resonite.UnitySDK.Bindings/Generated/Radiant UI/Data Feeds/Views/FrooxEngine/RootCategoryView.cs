
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RootCategoryView
// Generated on: pondělí 2. března 2026 17:53:26
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.DataFeedItemMappingManager CategoryManager = new();
public global::FrooxEngine.DataFeedItemMappingManager ItemsManager = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CategoryManager", CategoryManager.ToLinkSyncObject(context));
members.Add("ItemsManager", ItemsManager.ToLinkSyncObject(context));
}

}
}
