
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiBoolConditionDriver
// Generated on: čtvrtek 26. února 2026 12:28:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiBoolConditionDriver")]
public partial class MultiBoolConditionDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Boolean> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> Target_Element = new();
public global::FrooxEngine.MultiBoolConditionDriver.ConditionMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.MultiBoolConditionDriver.ConditionMode>, global::FrooxEngine.MultiBoolConditionDriver.ConditionMode> Mode_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.MultiBoolConditionDriver.Condition>, global::FrooxEngine.MultiBoolConditionDriver.Condition> Conditions = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("Conditions", Conditions.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
