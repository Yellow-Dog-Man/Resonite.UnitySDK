
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiChannelSimplexTexture3D
// Generated on: čtvrtek 26. února 2026 15:07:56
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.MultiChannelSimplexTexture3D.ChannelConfiguration R = new();
public global::FrooxEngine.MultiChannelSimplexTexture3D.ChannelConfiguration G = new();
public global::FrooxEngine.MultiChannelSimplexTexture3D.ChannelConfiguration B = new();
public global::FrooxEngine.MultiChannelSimplexTexture3D.ChannelConfiguration A = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("R", R.ToLinkSyncObject(context));
members.Add("G", G.ToLinkSyncObject(context));
members.Add("B", B.ToLinkSyncObject(context));
members.Add("A", A.ToLinkSyncObject(context));
}

}
}
