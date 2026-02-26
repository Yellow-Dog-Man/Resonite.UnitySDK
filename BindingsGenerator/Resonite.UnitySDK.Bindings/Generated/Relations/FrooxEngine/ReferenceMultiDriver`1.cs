
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceMultiDriver<>
// Generated on: čtvrtek 26. února 2026 15:09:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceMultiDriver<>")]
public partial class ReferenceMultiDriver<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public T Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<T>, T> Reference_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.RefDrive<T>>, global::FrooxEngine.SyncRef<T>, Reference<global::FrooxEngine.RefDrive<T>, global::FrooxEngine.SyncRef<T>>> Drives = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference_Element.ToLinkReference(context));
members.Add("Drives", Drives.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
