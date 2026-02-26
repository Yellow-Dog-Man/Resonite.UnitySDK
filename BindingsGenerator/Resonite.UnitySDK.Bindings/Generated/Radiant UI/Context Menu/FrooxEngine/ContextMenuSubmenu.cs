
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContextMenuSubmenu
// Generated on: čtvrtek 26. února 2026 15:09:01
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContextMenuSubmenu")]
public partial class ContextMenuSubmenu : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.Slot ItemsRoot { get => ItemsRoot_Element.Data; set => ItemsRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ItemsRoot_Element = new();
public global::System.Boolean SearchWholeHierarchy { get => SearchWholeHierarchy_Element.Data; set => SearchWholeHierarchy_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SearchWholeHierarchy_Element = new();
public global::System.Boolean DisableFlick { get => DisableFlick_Element.Data; set => DisableFlick_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DisableFlick_Element = new();
public global::System.Nullable<global::System.Single> SpeedOverride { get => SpeedOverride_Element.Data; set => SpeedOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> SpeedOverride_Element = new();
public global::System.Boolean CounterClockwise { get => CounterClockwise_Element.Data; set => CounterClockwise_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CounterClockwise_Element = new();
public global::System.Boolean KeepPosition { get => KeepPosition_Element.Data; set => KeepPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> KeepPosition_Element = new();
public global::System.Boolean Hidden { get => Hidden_Element.Data; set => Hidden_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Hidden_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemsRoot", ItemsRoot_Element.ToLinkReference(context));
members.Add("SearchWholeHierarchy", SearchWholeHierarchy_Element.ToLinkField(context));
members.Add("DisableFlick", DisableFlick_Element.ToLinkField(context));
members.Add("SpeedOverride", SpeedOverride_Element.ToLinkField(context));
members.Add("CounterClockwise", CounterClockwise_Element.ToLinkField(context));
members.Add("KeepPosition", KeepPosition_Element.ToLinkField(context));
members.Add("Hidden", Hidden_Element.ToLinkField(context));
}

}
}
