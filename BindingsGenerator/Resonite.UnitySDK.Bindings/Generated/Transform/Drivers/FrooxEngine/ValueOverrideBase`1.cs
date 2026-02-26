
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueOverrideBase<>
// Generated on: čtvrtek 26. února 2026 15:09:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueOverrideBase<>")]
public abstract partial class ValueOverrideBase<T> : global::FrooxEngine.Component
	

{
    public T Default { get => Default_Element.Data; set => Default_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> Default_Element = new();
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
members.Add("Default", Default_Element.ToLinkField(context));
members.Add("CreateOverrideOnWrite", CreateOverrideOnWrite_Element.ToLinkField(context));
members.Add("PersistentOverrides", PersistentOverrides_Element.ToLinkField(context));
members.Add("ClearOnUserLeave", ClearOnUserLeave_Element.ToLinkField(context));
}

}
}
