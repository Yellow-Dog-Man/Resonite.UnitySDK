
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandlerStreamDriver
// Generated on: pátek 13. února 2026 5:52:15
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractionHandlerStreamDriver")]
public partial class InteractionHandlerStreamDriver : global::FrooxEngine.UserRootComponent

{
    public global::Renderite.Shared.Chirality Side;
public global::FrooxEngine.ValueStream<global::System.Boolean> PrimaryBlockedStream;
public global::FrooxEngine.ValueStream<global::System.Boolean> SecondaryBlockedStream;
public global::FrooxEngine.ValueStream<global::System.Boolean> LaserActiveStream;
public global::FrooxEngine.ValueStream<global::System.Boolean> ShowLaserToOthersStream;
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> LaserTargetStream;
public global::FrooxEngine.ValueStream<global::System.Single> GrabDistanceStream;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Side", Side.ToResoniteLinkField());
members.Add("PrimaryBlockedStream", new ResoniteLink.Reference() { });
members.Add("SecondaryBlockedStream", new ResoniteLink.Reference() { });
members.Add("LaserActiveStream", new ResoniteLink.Reference() { });
members.Add("ShowLaserToOthersStream", new ResoniteLink.Reference() { });
members.Add("LaserTargetStream", new ResoniteLink.Reference() { });
members.Add("GrabDistanceStream", new ResoniteLink.Reference() { });
}

}
}
