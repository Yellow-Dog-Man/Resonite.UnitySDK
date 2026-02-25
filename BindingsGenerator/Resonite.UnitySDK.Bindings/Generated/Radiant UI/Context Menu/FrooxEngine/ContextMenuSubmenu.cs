
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContextMenuSubmenu
// Generated on: středa 25. února 2026 16:14:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContextMenuSubmenu")]
public partial class ContextMenuSubmenu : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.Slot ItemsRoot;
public global::System.Boolean SearchWholeHierarchy;
public global::System.Boolean DisableFlick;
public global::System.Nullable<global::System.Single> SpeedOverride;
public global::System.Boolean CounterClockwise;
public global::System.Boolean KeepPosition;
public global::System.Boolean Hidden;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemsRoot", ItemsRoot.ToResoniteReference(context));
members.Add("SearchWholeHierarchy", SearchWholeHierarchy.ToResoniteLinkField());
members.Add("DisableFlick", DisableFlick.ToResoniteLinkField());
members.Add("SpeedOverride", SpeedOverride.ToResoniteLinkField());
members.Add("CounterClockwise", CounterClockwise.ToResoniteLinkField());
members.Add("KeepPosition", KeepPosition.ToResoniteLinkField());
members.Add("Hidden", Hidden.ToResoniteLinkField());
}

}
}
