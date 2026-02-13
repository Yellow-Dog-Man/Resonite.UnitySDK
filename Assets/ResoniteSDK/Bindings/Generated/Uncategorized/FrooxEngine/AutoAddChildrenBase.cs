
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AutoAddChildrenBase
// Generated on: pátek 13. února 2026 5:52:25
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AutoAddChildrenBase")]
public abstract partial class AutoAddChildrenBase : global::FrooxEngine.Component

{
    public global::System.Boolean AutoAddChildren;
public System.Collections.Generic.List<global::System.String> AutoAddIgnoreTags;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AutoAddChildren", AutoAddChildren.ToResoniteLinkField());
members.Add("AutoAddIgnoreTags", new ResoniteLink.SyncList()
{
    Elements = AutoAddIgnoreTags.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
}

}
}
