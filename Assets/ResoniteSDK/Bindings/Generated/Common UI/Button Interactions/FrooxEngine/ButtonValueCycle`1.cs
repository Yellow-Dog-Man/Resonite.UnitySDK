
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonValueCycle<>
// Generated on: sobota 14. února 2026 8:57:03
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonValueCycle<>")]
public partial class ButtonValueCycle<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver
	

{
    public global::FrooxEngine.IField<T> TargetValue;
public System.Collections.Generic.List<T> Values;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetValue", TargetValue.ToResoniteReference(context));
members.Add("Values", new ResoniteLink.SyncList()
{
    Elements = Values.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
