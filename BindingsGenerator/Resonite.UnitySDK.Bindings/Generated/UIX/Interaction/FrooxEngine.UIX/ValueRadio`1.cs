
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ValueRadio<>
// Generated on: čtvrtek 26. února 2026 15:09:09
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ValueRadio<>")]
public partial class ValueRadio<T> : global::FrooxEngine.UIX.Radio
	

{
    public T OptionValue { get => OptionValue_Element.Data; set => OptionValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> OptionValue_Element = new();
public global::FrooxEngine.IField<T> TargetValue { get => TargetValue_Element.Data; set => TargetValue_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> TargetValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OptionValue", OptionValue_Element.ToLinkField(context));
members.Add("TargetValue", TargetValue_Element.ToLinkReference(context));
}

}
}
