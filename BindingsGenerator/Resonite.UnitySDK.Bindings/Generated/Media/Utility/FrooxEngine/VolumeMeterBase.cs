
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeMeterBase
// Generated on: čtvrtek 26. února 2026 12:26:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumeMeterBase")]
public abstract partial class VolumeMeterBase : global::FrooxEngine.Component

{
    public global::System.Single Smoothing { get => Smoothing_Element.Data; set => Smoothing_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Smoothing_Element = new();
public global::System.Single Power { get => Power_Element.Data; set => Power_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Power_Element = new();
public global::FrooxEngine.VolumeMeterMethod Method { get => Method_Element.Data; set => Method_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VolumeMeterMethod>, global::FrooxEngine.VolumeMeterMethod> Method_Element = new();
public global::FrooxEngine.IWorldAudioDataSource Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IWorldAudioDataSource>, global::FrooxEngine.IWorldAudioDataSource> Source_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Smoothing", Smoothing_Element.ToLinkField(context));
members.Add("Power", Power_Element.ToLinkField(context));
members.Add("Method", Method_Element.ToLinkField(context));
members.Add("Source", Source_Element.ToLinkReference(context));
}

}
}
