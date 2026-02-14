
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchEventRelay
// Generated on: sobota 14. února 2026 8:57:59
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchEventRelay")]
public partial class TouchEventRelay : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::System.Boolean AcceptOutOfSightTouch;
public System.Collections.Generic.List<global::FrooxEngine.ITouchable> TouchableTargets;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch.ToResoniteLinkField());
members.Add("TouchableTargets", new ResoniteLink.SyncList()
{
    Elements = TouchableTargets.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
