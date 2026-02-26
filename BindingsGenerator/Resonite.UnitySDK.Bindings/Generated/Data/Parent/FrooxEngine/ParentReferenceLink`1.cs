
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParentReferenceLink<>
// Generated on: čtvrtek 26. února 2026 12:26:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ParentReferenceLink<>")]
public partial class ParentReferenceLink<T> : global::FrooxEngine.ParentDataLink<T>
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.RefDrive<T>, global::FrooxEngine.SyncRef<T>> Target_Element = new();
public global::System.Boolean WriteBack { get => WriteBack_Element.Data; set => WriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WriteBack_Element = new();
public T DefaultReference { get => DefaultReference_Element.Data; set => DefaultReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> DefaultReference_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("WriteBack", WriteBack_Element.ToLinkField(context));
members.Add("DefaultReference", DefaultReference_Element.ToLinkReference(context));
}

}
}
