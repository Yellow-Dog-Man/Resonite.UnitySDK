
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GenericModalDialogSpawner<>
// Generated on: čtvrtek 26. února 2026 10:04:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GenericModalDialogSpawner<>")]
public partial class GenericModalDialogSpawner<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver
	where T : global::FrooxEngine.Component

{
    public UnityEngine.Vector2 Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Size_Element = new();
public global::System.Boolean CloseOnClick { get => CloseOnClick_Element.Data; set => CloseOnClick_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CloseOnClick_Element = new();
public global::System.Boolean CloseOnContextMenu { get => CloseOnContextMenu_Element.Data; set => CloseOnContextMenu_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CloseOnContextMenu_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.Data.ToResoniteLinkField());
members.Add("CloseOnClick", CloseOnClick_Element.Data.ToResoniteLinkField());
members.Add("CloseOnContextMenu", CloseOnContextMenu_Element.Data.ToResoniteLinkField());
}

}
}
