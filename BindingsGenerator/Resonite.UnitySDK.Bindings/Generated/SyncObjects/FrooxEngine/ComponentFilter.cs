
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ComponentFilter
// Generated on: pátek 6. března 2026 14:18:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ComponentFilter")]
public partial class ComponentFilter : global::FrooxEngine.SyncObject

{
    public global::SyncFieldList<global::FrooxEngine.SyncTypeList, System.String, Field<global::FrooxEngine.SyncType, System.String>> BlockedTypes = new();
public global::SyncFieldList<global::FrooxEngine.SyncTypeList, System.String, Field<global::FrooxEngine.SyncType, System.String>> RequiredTypes = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlockedTypes", BlockedTypes.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("RequiredTypes", RequiredTypes.ToLinkList(context, m => m.ToLinkField(context)));
}

}
}
