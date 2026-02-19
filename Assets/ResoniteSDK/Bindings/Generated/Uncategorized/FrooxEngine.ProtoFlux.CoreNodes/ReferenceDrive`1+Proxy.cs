
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.CoreNodes.ReferenceDrive<>+Proxy
// Generated on: čtvrtek 19. února 2026 7:59:45
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.CoreNodes
{
    public partial class ReferenceDrive<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.CoreNodes.ReferenceDrive<>+Proxy")]
public partial class Proxy : global::FrooxEngine.ProtoFlux.ProtoFluxEngineProxy

{
    public global::FrooxEngine.SyncRef<T> Drive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Drive", Drive.ToResoniteReference(context));
}

}
            }
}
