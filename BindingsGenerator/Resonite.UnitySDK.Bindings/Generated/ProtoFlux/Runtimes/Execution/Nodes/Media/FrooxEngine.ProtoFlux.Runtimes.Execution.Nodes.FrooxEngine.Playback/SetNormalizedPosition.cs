
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Playback.SetNormalizedPosition
// Generated on: čtvrtek 26. února 2026 12:27:44
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Playback
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Playback.SetNormalizedPosition")]
public partial class SetNormalizedPosition : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Playback.PlaybackAction

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> NormalizedPosition { get => NormalizedPosition_Element.Data; set => NormalizedPosition_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> NormalizedPosition_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NormalizedPosition", NormalizedPosition_Element.ToLinkReference(context));
}

}
}
