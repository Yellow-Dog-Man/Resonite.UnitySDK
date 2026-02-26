
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicField<>
// Generated on: čtvrtek 26. února 2026 15:07:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicField<>")]
public partial class DynamicField<T> : global::FrooxEngine.DynamicVariableBase<T>
	

{
    public global::FrooxEngine.IField<T> TargetField { get => TargetField_Element.Data; set => TargetField_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> TargetField_Element = new();
public global::System.Boolean OverrideOnLink { get => OverrideOnLink_Element.Data; set => OverrideOnLink_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OverrideOnLink_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetField", TargetField_Element.ToLinkReference(context));
members.Add("OverrideOnLink", OverrideOnLink_Element.ToLinkField(context));
}

}
}
