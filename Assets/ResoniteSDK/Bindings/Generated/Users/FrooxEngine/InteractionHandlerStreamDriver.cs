
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandlerStreamDriver
// Generated on: sobota 14. února 2026 8:58:27
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Side", Side.ToResoniteLinkField());
members.Add("PrimaryBlockedStream", PrimaryBlockedStream.ToResoniteReference(context));
members.Add("SecondaryBlockedStream", SecondaryBlockedStream.ToResoniteReference(context));
members.Add("LaserActiveStream", LaserActiveStream.ToResoniteReference(context));
members.Add("ShowLaserToOthersStream", ShowLaserToOthersStream.ToResoniteReference(context));
members.Add("LaserTargetStream", LaserTargetStream.ToResoniteReference(context));
members.Add("GrabDistanceStream", GrabDistanceStream.ToResoniteReference(context));
}

}
}
