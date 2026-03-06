
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedItemMappingManager
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataFeedItemMappingManager")]
public partial class DataFeedItemMappingManager : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot ContainerRoot { get => ContainerRoot_Element.Data; set => ContainerRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ContainerRoot_Element = new();
public global::FrooxEngine.DataFeedItemMapper TemplateMapper { get => TemplateMapper_Element.Data; set => TemplateMapper_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.DataFeedItemMapper>, global::FrooxEngine.DataFeedItemMapper> TemplateMapper_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ContainerRoot", ContainerRoot_Element.ToLinkReference(context));
members.Add("TemplateMapper", TemplateMapper_Element.ToLinkReference(context));
}

}
}
