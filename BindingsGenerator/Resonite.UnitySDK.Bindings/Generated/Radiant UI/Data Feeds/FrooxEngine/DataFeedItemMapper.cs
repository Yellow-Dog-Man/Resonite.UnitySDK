
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedItemMapper
// Generated on: středa 25. února 2026 16:14:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataFeedItemMapper")]
public partial class DataFeedItemMapper : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public System.Collections.Generic.List<global::FrooxEngine.DataFeedItemMapper.ItemMapping> Mappings;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mappings", new ResoniteLink.SyncList()
{
    Elements = Mappings.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
