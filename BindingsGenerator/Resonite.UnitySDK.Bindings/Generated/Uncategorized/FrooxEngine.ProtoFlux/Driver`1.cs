
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.Driver<>
// Generated on: pátek 6. března 2026 14:19:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.Driver<>")]
public partial class Driver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.ProtoFlux.INodeOutput<T> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOutput<T>>, global::FrooxEngine.ProtoFlux.INodeOutput<T>> Source_Element = new();
public global::FrooxEngine.IField<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> Target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("Target", Target_Element.ToLinkReference(context));
}

}
}
