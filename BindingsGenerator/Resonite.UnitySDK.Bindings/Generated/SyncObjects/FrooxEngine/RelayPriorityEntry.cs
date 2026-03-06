
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RelayPriorityEntry
// Generated on: pátek 6. března 2026 14:19:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RelayPriorityEntry")]
public partial class RelayPriorityEntry : global::FrooxEngine.PriorityEntry<global::System.String>

{
    public global::System.String RelayIP { get => RelayIP_Element.Data; set => RelayIP_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> RelayIP_Element = new();
public global::System.Int32 CurrentUsers { get => CurrentUsers_Element.Data; set => CurrentUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> CurrentUsers_Element = new();
public global::System.Boolean IsAvailable { get => IsAvailable_Element.Data; set => IsAvailable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsAvailable_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RelayIP", RelayIP_Element.ToLinkField(context));
members.Add("CurrentUsers", CurrentUsers_Element.ToLinkField(context));
members.Add("IsAvailable", IsAvailable_Element.ToLinkField(context));
}

}
}
