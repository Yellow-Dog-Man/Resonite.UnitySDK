
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxNodeDebugInfo
// Generated on: pátek 13. února 2026 23:21:42
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxNodeDebugInfo")]
public partial class ProtoFluxNodeDebugInfo : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.ProtoFluxNode Node;
public global::System.Boolean IsBuilt;
public global::System.Int32 IndexInGroup;
public global::System.Int32 AllocationIndex;
public global::System.String GroupName;
public global::System.Boolean GroupIsValid;
public global::System.Int32 GroupNodeCount;
public global::System.Int32 NodeInstanceHash;
public global::System.Boolean GroupRegisteredForContinuousChanges;
public global::System.Boolean GroupRegisteredForUpdates;
public global::System.Boolean NodeContinuouslyChanging;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Node", new ResoniteLink.Reference() { });
members.Add("IsBuilt", IsBuilt.ToResoniteLinkField());
members.Add("IndexInGroup", IndexInGroup.ToResoniteLinkField());
members.Add("AllocationIndex", AllocationIndex.ToResoniteLinkField());
members.Add("GroupName", GroupName.ToResoniteLinkField());
members.Add("GroupIsValid", GroupIsValid.ToResoniteLinkField());
members.Add("GroupNodeCount", GroupNodeCount.ToResoniteLinkField());
members.Add("NodeInstanceHash", NodeInstanceHash.ToResoniteLinkField());
members.Add("GroupRegisteredForContinuousChanges", GroupRegisteredForContinuousChanges.ToResoniteLinkField());
members.Add("GroupRegisteredForUpdates", GroupRegisteredForUpdates.ToResoniteLinkField());
members.Add("NodeContinuouslyChanging", NodeContinuouslyChanging.ToResoniteLinkField());
}

}
}
