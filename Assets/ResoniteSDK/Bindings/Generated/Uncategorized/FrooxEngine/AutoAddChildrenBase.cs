
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AutoAddChildrenBase
// Generated on: sobota 14. února 2026 8:58:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AutoAddChildrenBase")]
public abstract partial class AutoAddChildrenBase : global::FrooxEngine.Component

{
    public global::System.Boolean AutoAddChildren;
public System.Collections.Generic.List<global::System.String> AutoAddIgnoreTags;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AutoAddChildren", AutoAddChildren.ToResoniteLinkField());
members.Add("AutoAddIgnoreTags", new ResoniteLink.SyncList()
{
    Elements = AutoAddIgnoreTags.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
