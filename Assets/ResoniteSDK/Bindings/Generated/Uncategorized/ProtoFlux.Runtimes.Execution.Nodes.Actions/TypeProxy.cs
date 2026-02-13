
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFlux.Nodes.FrooxEngine]ProtoFlux.Runtimes.Execution.Nodes.Actions.TypeProxy
// Generated on: pátek 13. února 2026 23:22:30
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFlux.Nodes.FrooxEngine]ProtoFlux.Runtimes.Execution.Nodes.Actions.TypeProxy")]
public partial class TypeProxy : global::FrooxEngine.ProtoFlux.ProtoFluxEngineProxy, global::ProtoFlux.Runtimes.Execution.Nodes.Actions.ILastValueProxy<System.String>

{
    public System.String Last;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Last", Last.ToResoniteLinkField());
}

}
}
