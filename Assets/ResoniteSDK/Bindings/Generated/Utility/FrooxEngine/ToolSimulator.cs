
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ToolSimulator
// Generated on: pátek 13. února 2026 5:52:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ToolSimulator")]
public partial class ToolSimulator : global::FrooxEngine.Component

{
    public global::FrooxEngine.ITool Tool;
public global::FrooxEngine.User SimulatingUser;
public global::System.Boolean Primary;
public global::System.Boolean Secondary;
public global::System.Single Strength;
public UnityEngine.Vector2 Axis;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Tool", new ResoniteLink.Reference() { });
members.Add("SimulatingUser", new ResoniteLink.Reference() { });
members.Add("Primary", Primary.ToResoniteLinkField());
members.Add("Secondary", Secondary.ToResoniteLinkField());
members.Add("Strength", Strength.ToResoniteLinkField());
members.Add("Axis", Axis.ToResoniteLinkField());
}

}
}
