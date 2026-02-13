
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedItemMappingManager
// Generated on: pátek 13. února 2026 23:23:02
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataFeedItemMappingManager")]
public partial class DataFeedItemMappingManager : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot ContainerRoot;
public global::FrooxEngine.DataFeedItemMapper TemplateMapper;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ContainerRoot", new ResoniteLink.Reference() { });
members.Add("TemplateMapper", new ResoniteLink.Reference() { });
}

}
}
