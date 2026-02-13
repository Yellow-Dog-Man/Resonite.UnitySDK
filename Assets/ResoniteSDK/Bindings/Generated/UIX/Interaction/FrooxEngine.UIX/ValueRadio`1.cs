
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ValueRadio<>
// Generated on: pátek 13. února 2026 23:23:11
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OptionValue", OptionValue.ToResoniteLinkField());
members.Add("TargetValue", new ResoniteLink.Reference() { });
}

}
}
