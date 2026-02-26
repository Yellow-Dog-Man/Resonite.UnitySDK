
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedItemMappingManager
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataFeedItemMappingManager")]
public partial class DataFeedItemMappingManager : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Slot ContainerRoot { get => ContainerRoot_Element.Data; set => ContainerRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ContainerRoot_Element = new();
public global::FrooxEngine.DataFeedItemMapper TemplateMapper { get => TemplateMapper_Element.Data; set => TemplateMapper_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.DataFeedItemMapper>, global::FrooxEngine.DataFeedItemMapper> TemplateMapper_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ContainerRoot", ContainerRoot_Element.Data.ToResoniteReference(context));
members.Add("TemplateMapper", TemplateMapper_Element.Data.ToResoniteReference(context));
}

}
}
