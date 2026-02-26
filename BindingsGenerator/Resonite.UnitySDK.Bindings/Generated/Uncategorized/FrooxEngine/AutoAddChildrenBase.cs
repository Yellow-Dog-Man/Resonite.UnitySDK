
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AutoAddChildrenBase
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AutoAddChildrenBase")]
public abstract partial class AutoAddChildrenBase : global::FrooxEngine.Component

{
    public global::System.Boolean AutoAddChildren { get => AutoAddChildren_Element.Data; set => AutoAddChildren_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoAddChildren_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> AutoAddIgnoreTags = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AutoAddChildren", AutoAddChildren_Element.Data.ToResoniteLinkField());
members.Add("AutoAddIgnoreTags", new ResoniteLink.SyncList()
{
    Elements = AutoAddIgnoreTags.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
}

}
}
