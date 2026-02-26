
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchEventRelay
// Generated on: čtvrtek 26. února 2026 10:04:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchEventRelay")]
public partial class TouchEventRelay : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::System.Boolean AcceptOutOfSightTouch { get => AcceptOutOfSightTouch_Element.Data; set => AcceptOutOfSightTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptOutOfSightTouch_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ITouchable>, global::FrooxEngine.ITouchable, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ITouchable>, global::FrooxEngine.ITouchable>> TouchableTargets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch_Element.Data.ToResoniteLinkField());
members.Add("TouchableTargets", new ResoniteLink.SyncList()
{
    Elements = TouchableTargets.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
}

}
}
