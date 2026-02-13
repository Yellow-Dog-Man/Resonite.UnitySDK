
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiBoolConditionDriver+Condition
// Generated on: pátek 13. února 2026 5:52:26
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
    public partial class MultiBoolConditionDriver
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiBoolConditionDriver+Condition")]
public partial class Condition : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<global::System.Boolean> Field;
public global::System.Boolean Invert;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Field", new ResoniteLink.Reference() { });
members.Add("Invert", Invert.ToResoniteLinkField());
}

}
            }
}
