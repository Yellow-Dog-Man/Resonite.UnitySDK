
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PriorityEntry
// Generated on: pátek 6. března 2026 14:19:07
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PriorityEntry")]
public abstract partial class PriorityEntry : global::FrooxEngine.SyncObject

{
    public global::System.Int32 Priority { get => Priority_Element.Data; set => Priority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Priority_Element = new();
public global::System.Boolean IsFirst { get => IsFirst_Element.Data; set => IsFirst_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsFirst_Element = new();
public global::System.Boolean IsLast { get => IsLast_Element.Data; set => IsLast_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsLast_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Priority", Priority_Element.ToLinkField(context));
members.Add("IsFirst", IsFirst_Element.ToLinkField(context));
members.Add("IsLast", IsLast_Element.ToLinkField(context));
}

}
}
