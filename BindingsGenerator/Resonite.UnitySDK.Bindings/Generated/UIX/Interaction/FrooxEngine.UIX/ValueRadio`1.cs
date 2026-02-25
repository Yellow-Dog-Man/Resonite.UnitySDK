
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ValueRadio<>
// Generated on: středa 25. února 2026 16:14:34
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public T OptionValue;
public global::FrooxEngine.IField<T> TargetValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OptionValue", OptionValue.ToResoniteLinkField());
members.Add("TargetValue", TargetValue.ToResoniteReference(context));
}

}
}
