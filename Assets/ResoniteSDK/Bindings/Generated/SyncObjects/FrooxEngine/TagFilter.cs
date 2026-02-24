
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TagFilter
// Generated on: úterý 24. února 2026 18:17:53
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
