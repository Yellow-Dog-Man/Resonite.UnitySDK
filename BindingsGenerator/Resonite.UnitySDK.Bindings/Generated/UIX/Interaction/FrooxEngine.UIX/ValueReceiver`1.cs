
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ValueReceiver<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ValueReceiver<>")]
public partial class ValueReceiver<T> : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabReceiver, global::FrooxEngine.UIX.IValueReceiver
	

{
    public global::FrooxEngine.IField<T> Field;
public global::System.Boolean Undoable;
public global::System.Boolean TryConvertValues;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Field", Field.ToResoniteReference(context));
members.Add("Undoable", Undoable.ToResoniteLinkField());
members.Add("TryConvertValues", TryConvertValues.ToResoniteLinkField());
}

}
}
