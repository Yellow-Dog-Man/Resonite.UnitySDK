
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceUserOverride<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceUserOverride<>")]
public partial class ReferenceUserOverride<T> : global::FrooxEngine.Component
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.RefDrive<T>, global::FrooxEngine.SyncRef<T>> Target_Element = new();
public T Default { get => Default_Element.Data; set => Default_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> Default_Element = new();
public global::System.Boolean CreateOverrideOnWrite { get => CreateOverrideOnWrite_Element.Data; set => CreateOverrideOnWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CreateOverrideOnWrite_Element = new();
public global::System.Boolean PersistentOverrides { get => PersistentOverrides_Element.Data; set => PersistentOverrides_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PersistentOverrides_Element = new();
public global::System.Boolean ClearOnUserLeave { get => ClearOnUserLeave_Element.Data; set => ClearOnUserLeave_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ClearOnUserLeave_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Default", Default_Element.ToLinkReference(context));
members.Add("CreateOverrideOnWrite", CreateOverrideOnWrite_Element.ToLinkField(context));
members.Add("PersistentOverrides", PersistentOverrides_Element.ToLinkField(context));
members.Add("ClearOnUserLeave", ClearOnUserLeave_Element.ToLinkField(context));
}

}
}
