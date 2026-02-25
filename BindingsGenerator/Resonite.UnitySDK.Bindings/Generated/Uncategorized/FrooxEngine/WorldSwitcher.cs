
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldSwitcher
// Generated on: středa 25. února 2026 16:14:44
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Show", Show.ToResoniteLinkField());
members.Add("IgnoreTouchesFrom", IgnoreTouchesFrom.ToResoniteReference(context));
members.Add("_repulsionTree", _repulsionTree.ToResoniteReference(context));
members.Add("_linesMesh", _linesMesh.ToResoniteReference(context));
members.Add("_slider", _slider.ToResoniteReference(context));
members.Add("_centerOrb", _centerOrb.ToResoniteReference(context));
members.Add("_visualRoot", _visualRoot.ToResoniteReference(context));
}

}
}
