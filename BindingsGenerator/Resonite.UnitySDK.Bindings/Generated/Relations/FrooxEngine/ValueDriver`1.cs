
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueDriver<>
// Generated on: čtvrtek 26. února 2026 12:28:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueDriver<>")]
public partial class ValueDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IValue<T> ValueSource { get => ValueSource_Element.Data; set => ValueSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IValue<T>>, global::FrooxEngine.IValue<T>> ValueSource_Element = new();
public global::FrooxEngine.IField<T> DriveTarget { get => DriveTarget_Element.Data; set => DriveTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> DriveTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ValueSource", ValueSource_Element.ToLinkReference(context));
members.Add("DriveTarget", DriveTarget_Element.ToLinkReference(context));
}

}
}
