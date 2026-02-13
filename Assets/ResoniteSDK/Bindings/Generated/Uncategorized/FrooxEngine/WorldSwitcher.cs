
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldSwitcher
// Generated on: pátek 13. února 2026 5:52:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldSwitcher")]
public partial class WorldSwitcher : global::FrooxEngine.Component

{
    public global::System.Boolean Show;
public global::FrooxEngine.Slot IgnoreTouchesFrom;
public global::FrooxEngine.RepulsionTreeSimulator _repulsionTree;
public global::FrooxEngine.MultiSegmentMesh _linesMesh;
public global::FrooxEngine.Slider _slider;
public global::FrooxEngine.Slot _centerOrb;
public global::FrooxEngine.Slot _visualRoot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Show", Show.ToResoniteLinkField());
members.Add("IgnoreTouchesFrom", new ResoniteLink.Reference() { });
members.Add("_repulsionTree", new ResoniteLink.Reference() { });
members.Add("_linesMesh", new ResoniteLink.Reference() { });
members.Add("_slider", new ResoniteLink.Reference() { });
members.Add("_centerOrb", new ResoniteLink.Reference() { });
members.Add("_visualRoot", new ResoniteLink.Reference() { });
}

}
}
