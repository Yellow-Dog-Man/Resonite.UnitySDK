
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxNodeDebugInfo
// Generated on: pátek 6. března 2026 14:18:10
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.ProtoFlux.ProtoFluxNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ProtoFluxNode>, global::FrooxEngine.ProtoFlux.ProtoFluxNode> Node_Element = new();
public global::System.Boolean IsBuilt { get => IsBuilt_Element.Data; set => IsBuilt_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsBuilt_Element = new();
public global::System.Int32 IndexInGroup { get => IndexInGroup_Element.Data; set => IndexInGroup_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> IndexInGroup_Element = new();
public global::System.Int32 AllocationIndex { get => AllocationIndex_Element.Data; set => AllocationIndex_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> AllocationIndex_Element = new();
public global::System.String GroupName { get => GroupName_Element.Data; set => GroupName_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> GroupName_Element = new();
public global::System.Boolean GroupIsValid { get => GroupIsValid_Element.Data; set => GroupIsValid_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> GroupIsValid_Element = new();
public global::System.Int32 GroupNodeCount { get => GroupNodeCount_Element.Data; set => GroupNodeCount_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> GroupNodeCount_Element = new();
public global::System.Int32 NodeInstanceHash { get => NodeInstanceHash_Element.Data; set => NodeInstanceHash_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> NodeInstanceHash_Element = new();
public global::System.Boolean GroupRegisteredForContinuousChanges { get => GroupRegisteredForContinuousChanges_Element.Data; set => GroupRegisteredForContinuousChanges_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> GroupRegisteredForContinuousChanges_Element = new();
public global::System.Boolean GroupRegisteredForUpdates { get => GroupRegisteredForUpdates_Element.Data; set => GroupRegisteredForUpdates_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> GroupRegisteredForUpdates_Element = new();
public global::System.Boolean NodeContinuouslyChanging { get => NodeContinuouslyChanging_Element.Data; set => NodeContinuouslyChanging_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> NodeContinuouslyChanging_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.ToLinkReference(context));
members.Add("IsBuilt", IsBuilt_Element.ToLinkField(context));
members.Add("IndexInGroup", IndexInGroup_Element.ToLinkField(context));
members.Add("AllocationIndex", AllocationIndex_Element.ToLinkField(context));
members.Add("GroupName", GroupName_Element.ToLinkField(context));
members.Add("GroupIsValid", GroupIsValid_Element.ToLinkField(context));
members.Add("GroupNodeCount", GroupNodeCount_Element.ToLinkField(context));
members.Add("NodeInstanceHash", NodeInstanceHash_Element.ToLinkField(context));
members.Add("GroupRegisteredForContinuousChanges", GroupRegisteredForContinuousChanges_Element.ToLinkField(context));
members.Add("GroupRegisteredForUpdates", GroupRegisteredForUpdates_Element.ToLinkField(context));
members.Add("NodeContinuouslyChanging", NodeContinuouslyChanging_Element.ToLinkField(context));
}

}
}
