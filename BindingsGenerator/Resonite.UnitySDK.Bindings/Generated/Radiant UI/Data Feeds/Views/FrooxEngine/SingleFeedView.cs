
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SingleFeedView
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SingleFeedView")]
public partial class SingleFeedView : global::FrooxEngine.DataFeedViewBase

{
    public global::FrooxEngine.DataFeedItemMappingManager ItemsManager = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemsManager", ItemsManager.ToLinkSyncObject(context));
}

}
}
