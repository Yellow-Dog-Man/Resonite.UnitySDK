
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxEngineProxy
// Generated on: sobota 14. února 2026 8:57:49
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxEngineProxy")]
public abstract partial class ProtoFluxEngineProxy : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.IProtoFluxNode Node;
public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.IProtoFluxNode> Path;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node.ToResoniteReference(context));
members.Add("Path", new ResoniteLink.SyncList()
{
    Elements = Path.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
