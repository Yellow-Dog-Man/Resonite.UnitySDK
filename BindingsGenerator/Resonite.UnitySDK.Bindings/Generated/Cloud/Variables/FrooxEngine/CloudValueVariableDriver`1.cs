
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloudValueVariableDriver<>
// Generated on: čtvrtek 26. února 2026 10:03:37
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloudValueVariableDriver<>")]
public partial class CloudValueVariableDriver<T> : global::FrooxEngine.CloudVariableBase
	

{
    public global::FrooxEngine.IField<T> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> Target_Element = new();
public global::System.Boolean IsLinkedToCloud { get => IsLinkedToCloud_Element.Data; set => IsLinkedToCloud_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsLinkedToCloud_Element = new();
public global::System.Boolean WriteBack { get => WriteBack_Element.Data; set => WriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WriteBack_Element = new();
public T FallbackValue { get => FallbackValue_Element.Data; set => FallbackValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> FallbackValue_Element = new();
public global::System.String OverrideOwner { get => OverrideOwner_Element.Data; set => OverrideOwner_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> OverrideOwner_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("IsLinkedToCloud", IsLinkedToCloud_Element.Data.ToResoniteLinkField());
members.Add("WriteBack", WriteBack_Element.Data.ToResoniteLinkField());
members.Add("FallbackValue", FallbackValue_Element.Data.ToResoniteLinkField());
members.Add("OverrideOwner", OverrideOwner_Element.Data.ToResoniteLinkField());
}

}
}
