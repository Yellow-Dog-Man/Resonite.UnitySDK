
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiChannelSimplexTexture3D+ChannelConfiguration
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
    public partial class MultiChannelSimplexTexture3D
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiChannelSimplexTexture3D+ChannelConfiguration")]
public partial class ChannelConfiguration : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 Scale;
public global::System.Boolean Use4D;
public global::System.Single WOffset;
public global::System.Single Min;
public global::System.Single Max;
public global::System.Single Exp;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("Use4D", Use4D.ToResoniteLinkField());
members.Add("WOffset", WOffset.ToResoniteLinkField());
members.Add("Min", Min.ToResoniteLinkField());
members.Add("Max", Max.ToResoniteLinkField());
members.Add("Exp", Exp.ToResoniteLinkField());
}

}
            }
}
