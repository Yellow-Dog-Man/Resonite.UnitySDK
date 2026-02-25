
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TagFilter
// Generated on: středa 25. února 2026 16:13:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TagFilter")]
public partial class TagFilter : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.ListFilterMode Mode;
public System.Collections.Generic.List<global::System.String> List;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("List", new ResoniteLink.SyncList()
{
    Elements = List.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
