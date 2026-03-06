
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ValueReceiver<>
// Generated on: pátek 6. března 2026 14:19:07
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.IField<T> Field { get => Field_Element.Data; set => Field_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<T>>, global::FrooxEngine.IField<T>> Field_Element = new();
public global::System.Boolean Undoable { get => Undoable_Element.Data; set => Undoable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Undoable_Element = new();
public global::System.Boolean TryConvertValues { get => TryConvertValues_Element.Data; set => TryConvertValues_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TryConvertValues_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Field", Field_Element.ToLinkReference(context));
members.Add("Undoable", Undoable_Element.ToLinkField(context));
members.Add("TryConvertValues", TryConvertValues_Element.ToLinkField(context));
}

}
}
