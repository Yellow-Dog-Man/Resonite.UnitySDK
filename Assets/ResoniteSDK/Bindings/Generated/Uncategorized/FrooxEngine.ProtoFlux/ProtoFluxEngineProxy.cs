
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxEngineProxy
// Generated on: pátek 13. února 2026 23:22:21
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxEngineProxy")]
public abstract partial class ProtoFluxEngineProxy : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.IProtoFluxNode Node;
public System.Collections.Generic.List<global::FrooxEngine.ProtoFlux.IProtoFluxNode> Path;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Node", new ResoniteLink.Reference() { });
members.Add("Path", new ResoniteLink.SyncList()
{
    Elements = Path.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}
