
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceCast<,>
// Generated on: čtvrtek 26. února 2026 12:28:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceCast<,>")]
public partial class ReferenceCast<I,O> : global::FrooxEngine.Component
	where O : class, global::FrooxEngine.IWorldElement
	where I : class, global::FrooxEngine.IWorldElement

{
    public I Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<I>, I> Source_Element = new();
public global::FrooxEngine.SyncRef<O> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.RefDrive<O>, global::FrooxEngine.SyncRef<O>> Target_Element = new();
public global::System.Boolean WriteBack { get => WriteBack_Element.Data; set => WriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WriteBack_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("WriteBack", WriteBack_Element.ToLinkField(context));
}

}
}
