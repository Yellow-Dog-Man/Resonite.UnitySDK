
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiChannelSimplexTexture3D
// Generated on: sobota 14. února 2026 8:57:00
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiChannelSimplexTexture3D")]
public partial class MultiChannelSimplexTexture3D : global::FrooxEngine.ProceduralTexture3D

{
    public global::FrooxEngine.MultiChannelSimplexTexture3D.ChannelConfiguration R;
public global::FrooxEngine.MultiChannelSimplexTexture3D.ChannelConfiguration G;
public global::FrooxEngine.MultiChannelSimplexTexture3D.ChannelConfiguration B;
public global::FrooxEngine.MultiChannelSimplexTexture3D.ChannelConfiguration A;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("R", new ResoniteLink.SyncObject() { Members = R.CollectMembers(context) });
members.Add("G", new ResoniteLink.SyncObject() { Members = G.CollectMembers(context) });
members.Add("B", new ResoniteLink.SyncObject() { Members = B.CollectMembers(context) });
members.Add("A", new ResoniteLink.SyncObject() { Members = A.CollectMembers(context) });
}

}
}
