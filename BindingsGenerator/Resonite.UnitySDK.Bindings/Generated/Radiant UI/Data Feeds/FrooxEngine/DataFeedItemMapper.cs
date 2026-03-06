
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedItemMapper
// Generated on: pátek 6. března 2026 14:19:02
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataFeedItemMapper")]
public partial class DataFeedItemMapper : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.DataFeedItemMapper.ItemMapping>, global::FrooxEngine.DataFeedItemMapper.ItemMapping> Mappings = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mappings", Mappings.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
