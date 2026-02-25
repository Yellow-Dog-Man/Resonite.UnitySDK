
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ComponentFilter
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ComponentFilter")]
public partial class ComponentFilter : global::FrooxEngine.SyncObject

{
    public System.Collections.Generic.List<System.String> BlockedTypes;
public System.Collections.Generic.List<System.String> RequiredTypes;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
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
