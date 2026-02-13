
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotInspector
// Generated on: pátek 13. února 2026 23:23:18
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotInspector")]
public partial class SlotInspector : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncRef<global::FrooxEngine.Slot> _selectionReference;
public global::FrooxEngine.Slot _rootSlot;
public global::FrooxEngine.Slot _childContainer;
public global::System.Int32 _depth;
public global::FrooxEngine.UIX.Expander _expander;
public global::FrooxEngine.UIX.TextExpandIndicator _expanderIndicator;
public global::FrooxEngine.UIX.Text _slotNameText;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_selectionReference", new ResoniteLink.Reference() { });
members.Add("_rootSlot", new ResoniteLink.Reference() { });
members.Add("_childContainer", new ResoniteLink.Reference() { });
members.Add("_depth", _depth.ToResoniteLinkField());
members.Add("_expander", new ResoniteLink.Reference() { });
members.Add("_expanderIndicator", new ResoniteLink.Reference() { });
members.Add("_slotNameText", new ResoniteLink.Reference() { });
}

}
}
