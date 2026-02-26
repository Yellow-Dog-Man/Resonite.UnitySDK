
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldCloseAction
// Generated on: čtvrtek 26. února 2026 10:04:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldCloseAction")]
public partial class WorldCloseAction : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.WorldCloseAction.CloseAction Action { get => Action_Element.Data; set => Action_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.WorldCloseAction.CloseAction>, global::FrooxEngine.WorldCloseAction.CloseAction> Action_Element = new();
public global::System.Boolean WaitingConfirm { get => WaitingConfirm_Element.Data; set => WaitingConfirm_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WaitingConfirm_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Action", Action_Element.Data.ToResoniteLinkField());
members.Add("WaitingConfirm", WaitingConfirm_Element.Data.ToResoniteLinkField());
}

}
}
