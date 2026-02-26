
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandlerStreamDriver
// Generated on: čtvrtek 26. února 2026 12:27:57
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::Renderite.Shared.Chirality Side { get => Side_Element.Data; set => Side_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> Side_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> PrimaryBlockedStream { get => PrimaryBlockedStream_Element.Data; set => PrimaryBlockedStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> PrimaryBlockedStream_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> SecondaryBlockedStream { get => SecondaryBlockedStream_Element.Data; set => SecondaryBlockedStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> SecondaryBlockedStream_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> LaserActiveStream { get => LaserActiveStream_Element.Data; set => LaserActiveStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> LaserActiveStream_Element = new();
public global::FrooxEngine.ValueStream<global::System.Boolean> ShowLaserToOthersStream { get => ShowLaserToOthersStream_Element.Data; set => ShowLaserToOthersStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> ShowLaserToOthersStream_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> LaserTargetStream { get => LaserTargetStream_Element.Data; set => LaserTargetStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector3>>, global::FrooxEngine.ValueStream<UnityEngine.Vector3>> LaserTargetStream_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> GrabDistanceStream { get => GrabDistanceStream_Element.Data; set => GrabDistanceStream_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> GrabDistanceStream_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Side", Side_Element.ToLinkField(context));
members.Add("PrimaryBlockedStream", PrimaryBlockedStream_Element.ToLinkReference(context));
members.Add("SecondaryBlockedStream", SecondaryBlockedStream_Element.ToLinkReference(context));
members.Add("LaserActiveStream", LaserActiveStream_Element.ToLinkReference(context));
members.Add("ShowLaserToOthersStream", ShowLaserToOthersStream_Element.ToLinkReference(context));
members.Add("LaserTargetStream", LaserTargetStream_Element.ToLinkReference(context));
members.Add("GrabDistanceStream", GrabDistanceStream_Element.ToLinkReference(context));
}

}
}
