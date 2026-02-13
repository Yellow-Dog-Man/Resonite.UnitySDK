
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ComponentFilter
// Generated on: pátek 13. února 2026 23:21:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ComponentFilter")]
public partial class ComponentFilter : global::FrooxEngine.SyncObject

{
    public System.Collections.Generic.List<System.String> BlockedTypes;
public System.Collections.Generic.List<System.String> RequiredTypes;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BlockedTypes", new ResoniteLink.SyncList()
{
    Elements = BlockedTypes.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("RequiredTypes", new ResoniteLink.SyncList()
{
    Elements = RequiredTypes.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
