
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedItemMappingManager
// Generated on: středa 25. února 2026 16:14:15
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
