
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedItemMappingManager
// Generated on: čtvrtek 19. února 2026 8:00:17
// Resonite version: 2026.2.19.471
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataFeedItemMappingManager")]
public partial class DataFeedItemMappingManager : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot ContainerRoot;
public global::FrooxEngine.DataFeedItemMapper TemplateMapper;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ContainerRoot", ContainerRoot.ToResoniteReference(context));
members.Add("TemplateMapper", TemplateMapper.ToResoniteReference(context));
}

}
}
