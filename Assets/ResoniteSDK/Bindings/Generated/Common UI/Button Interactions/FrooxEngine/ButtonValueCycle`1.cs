
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonValueCycle<>
// Generated on: pátek 13. února 2026 23:21:38
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetValue", new ResoniteLink.Reference() { });
members.Add("Values", new ResoniteLink.SyncList()
{
    Elements = Values.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
