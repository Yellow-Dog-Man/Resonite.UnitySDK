
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldSubmitter
// Generated on: čtvrtek 26. února 2026 12:26:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldSubmitter")]
public partial class WorldSubmitter : global::FrooxEngine.Component

{
    public global::System.String GroupId { get => GroupId_Element.Data; set => GroupId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> GroupId_Element = new();
public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Single Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Height_Element = new();
public global::FrooxEngine.Slot _visual { get => _visual_Element.Data; set => _visual_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visual_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GroupId", GroupId_Element.ToLinkField(context));
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("Height", Height_Element.ToLinkField(context));
members.Add("_visual", _visual_Element.ToLinkReference(context));
}

}
}
