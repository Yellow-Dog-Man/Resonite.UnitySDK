
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFlux.Nodes.FrooxEngine]ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time.Stopwatch+Proxy
// Generated on: pondělí 2. března 2026 17:53:22
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time
{
    public partial class Stopwatch
            {
                [Serializable]
[ResoniteTypeName("[ProtoFlux.Nodes.FrooxEngine]ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Time.Stopwatch+Proxy")]
public partial class Proxy : global::FrooxEngine.ProtoFlux.ProtoFluxEngineProxy

{
    public PlaybackState Stopwatch { get => Stopwatch_Element.Data; set => Stopwatch_Element.Data = value; }
public Field<global::FrooxEngine.SyncPlayback, PlaybackState> Stopwatch_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stopwatch", Stopwatch_Element.ToLinkPlayback(context));
}

}
            }
}
