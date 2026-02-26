
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MoveUpDataFeedCategory
// Generated on: čtvrtek 26. února 2026 12:28:01
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MoveUpDataFeedCategory")]
public partial class MoveUpDataFeedCategory : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.IDataFeedView View { get => View_Element.Data; set => View_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IDataFeedView>, global::FrooxEngine.IDataFeedView> View_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("View", View_Element.ToLinkReference(context));
}

}
}
