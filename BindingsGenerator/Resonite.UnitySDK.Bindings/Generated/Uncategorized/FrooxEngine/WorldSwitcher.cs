
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldSwitcher
// Generated on: čtvrtek 26. února 2026 10:04:49
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
    public global::System.Boolean Show { get => Show_Element.Data; set => Show_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Show_Element = new();
public global::FrooxEngine.Slot IgnoreTouchesFrom { get => IgnoreTouchesFrom_Element.Data; set => IgnoreTouchesFrom_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> IgnoreTouchesFrom_Element = new();
public global::FrooxEngine.RepulsionTreeSimulator _repulsionTree { get => _repulsionTree_Element.Data; set => _repulsionTree_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RepulsionTreeSimulator>, global::FrooxEngine.RepulsionTreeSimulator> _repulsionTree_Element = new();
public global::FrooxEngine.MultiSegmentMesh _linesMesh { get => _linesMesh_Element.Data; set => _linesMesh_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.MultiSegmentMesh>, global::FrooxEngine.MultiSegmentMesh> _linesMesh_Element = new();
public global::FrooxEngine.Slider _slider { get => _slider_Element.Data; set => _slider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slider>, global::FrooxEngine.Slider> _slider_Element = new();
public global::FrooxEngine.Slot _centerOrb { get => _centerOrb_Element.Data; set => _centerOrb_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _centerOrb_Element = new();
public global::FrooxEngine.Slot _visualRoot { get => _visualRoot_Element.Data; set => _visualRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visualRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Show", Show_Element.Data.ToResoniteLinkField());
members.Add("IgnoreTouchesFrom", IgnoreTouchesFrom_Element.Data.ToResoniteReference(context));
members.Add("_repulsionTree", _repulsionTree_Element.Data.ToResoniteReference(context));
members.Add("_linesMesh", _linesMesh_Element.Data.ToResoniteReference(context));
members.Add("_slider", _slider_Element.Data.ToResoniteReference(context));
members.Add("_centerOrb", _centerOrb_Element.Data.ToResoniteReference(context));
members.Add("_visualRoot", _visualRoot_Element.Data.ToResoniteReference(context));
}

}
}
