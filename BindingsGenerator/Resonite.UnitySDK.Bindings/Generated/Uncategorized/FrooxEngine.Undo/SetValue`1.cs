
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.SetValue<>
// Generated on: čtvrtek 26. února 2026 12:28:13
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Undo
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.SetValue<>")]
public partial class SetValue<T> : global::FrooxEngine.Component, global::FrooxEngine.Undo.IUndoable
	

{
    public global::FrooxEngine.IField<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Target_Element = new();
public T ValueBefore { get => ValueBefore_Element.Data; set => ValueBefore_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> ValueBefore_Element = new();
public T ValueAfter { get => ValueAfter_Element.Data; set => ValueAfter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> ValueAfter_Element = new();
public global::System.Boolean _performed { get => _performed_Element.Data; set => _performed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _performed_Element = new();
public global::System.String _description { get => _description_Element.Data; set => _description_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _description_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("ValueBefore", ValueBefore_Element.ToLinkField(context));
members.Add("ValueAfter", ValueAfter_Element.ToLinkField(context));
members.Add("_performed", _performed_Element.ToLinkField(context));
members.Add("_description", _description_Element.ToLinkField(context));
}

}
}
