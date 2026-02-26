
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ToolSimulator
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ToolSimulator")]
public partial class ToolSimulator : global::FrooxEngine.Component

{
    public global::FrooxEngine.ITool Tool { get => Tool_Element.Data; set => Tool_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ITool>, global::FrooxEngine.ITool> Tool_Element = new();
public global::FrooxEngine.User SimulatingUser { get => SimulatingUser_Element.Data; set => SimulatingUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> SimulatingUser_Element = new();
public global::System.Boolean Primary { get => Primary_Element.Data; set => Primary_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Primary_Element = new();
public global::System.Boolean Secondary { get => Secondary_Element.Data; set => Secondary_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Secondary_Element = new();
public global::System.Single Strength { get => Strength_Element.Data; set => Strength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Strength_Element = new();
public UnityEngine.Vector2 Axis { get => Axis_Element.Data; set => Axis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> Axis_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tool", Tool_Element.Data.ToResoniteReference(context));
members.Add("SimulatingUser", SimulatingUser_Element.Data.ToResoniteReference(context));
members.Add("Primary", Primary_Element.Data.ToResoniteLinkField());
members.Add("Secondary", Secondary_Element.Data.ToResoniteLinkField());
members.Add("Strength", Strength_Element.Data.ToResoniteLinkField());
members.Add("Axis", Axis_Element.Data.ToResoniteLinkField());
}

}
}
