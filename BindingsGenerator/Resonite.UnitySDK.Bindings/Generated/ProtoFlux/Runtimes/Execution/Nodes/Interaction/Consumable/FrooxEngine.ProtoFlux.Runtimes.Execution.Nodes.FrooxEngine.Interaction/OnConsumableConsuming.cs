
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.OnConsumableConsuming
// Generated on: pátek 14. srpna 2026 21:56:19
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.OnConsumableConsuming")]
public partial class OnConsumableConsuming : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.ConsumableEvents

{
    public global::FrooxEngine.ProtoFlux.ISyncNodeOperation OnConsuming { get => OnConsuming_Element.Data; set => OnConsuming_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> OnConsuming_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Int32> StageIndex = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Single> NormalizedConsumeProgress = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OnConsuming", OnConsuming_Element.ToLinkReference(context));
members.Add("StageIndex", StageIndex.ToLinkEmpty(context));
members.Add("NormalizedConsumeProgress", NormalizedConsumeProgress.ToLinkEmpty(context));
}

}
}
