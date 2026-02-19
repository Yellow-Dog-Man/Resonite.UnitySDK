
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiBoolConditionDriver
// Generated on: čtvrtek 19. února 2026 8:00:23
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.IField<global::System.Boolean> Target;
public global::FrooxEngine.MultiBoolConditionDriver.ConditionMode Mode;
public System.Collections.Generic.List<global::FrooxEngine.MultiBoolConditionDriver.Condition> Conditions;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("Conditions", new ResoniteLink.SyncList()
{
    Elements = Conditions.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
