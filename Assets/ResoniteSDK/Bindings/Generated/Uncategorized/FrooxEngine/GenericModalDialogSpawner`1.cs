
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GenericModalDialogSpawner<>
// Generated on: pátek 13. února 2026 5:52:32
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GenericModalDialogSpawner<>")]
public partial class GenericModalDialogSpawner<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver
	where T : global::FrooxEngine.Component

{
    public UnityEngine.Vector2 Size;
public global::System.Boolean CloseOnClick;
public global::System.Boolean CloseOnContextMenu;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Size", Size.ToResoniteLinkField());
members.Add("CloseOnClick", CloseOnClick.ToResoniteLinkField());
members.Add("CloseOnContextMenu", CloseOnContextMenu.ToResoniteLinkField());
}

}
}
