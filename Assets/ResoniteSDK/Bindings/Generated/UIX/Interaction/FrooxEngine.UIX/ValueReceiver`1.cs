
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ValueReceiver<>
// Generated on: pátek 13. února 2026 5:52:28
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ValueReceiver<>")]
public partial class ValueReceiver<T> : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabReceiver, global::FrooxEngine.UIX.IValueReceiver
	

{
    public global::FrooxEngine.IField<T> Field;
public global::System.Boolean Undoable;
public global::System.Boolean TryConvertValues;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Field", new ResoniteLink.Reference() { });
members.Add("Undoable", Undoable.ToResoniteLinkField());
members.Add("TryConvertValues", TryConvertValues.ToResoniteLinkField());
}

}
}
