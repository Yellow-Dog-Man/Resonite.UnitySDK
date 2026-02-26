
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotInspector
// Generated on: čtvrtek 26. února 2026 10:04:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlotInspector")]
public partial class SlotInspector : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncRef<global::FrooxEngine.Slot> _selectionReference { get => _selectionReference_Element.Data; set => _selectionReference_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>>, global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>> _selectionReference_Element = new();
public global::FrooxEngine.Slot _rootSlot { get => _rootSlot_Element.Data; set => _rootSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _rootSlot_Element = new();
public global::FrooxEngine.Slot _childContainer { get => _childContainer_Element.Data; set => _childContainer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _childContainer_Element = new();
public global::System.Int32 _depth { get => _depth_Element.Data; set => _depth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _depth_Element = new();
public global::FrooxEngine.UIX.Expander _expander { get => _expander_Element.Data; set => _expander_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Expander>, global::FrooxEngine.UIX.Expander> _expander_Element = new();
public global::FrooxEngine.UIX.TextExpandIndicator _expanderIndicator { get => _expanderIndicator_Element.Data; set => _expanderIndicator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextExpandIndicator>, global::FrooxEngine.UIX.TextExpandIndicator> _expanderIndicator_Element = new();
public global::FrooxEngine.UIX.Text _slotNameText { get => _slotNameText_Element.Data; set => _slotNameText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _slotNameText_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_selectionReference", _selectionReference_Element.Data.ToResoniteReference(context));
members.Add("_rootSlot", _rootSlot_Element.Data.ToResoniteReference(context));
members.Add("_childContainer", _childContainer_Element.Data.ToResoniteReference(context));
members.Add("_depth", _depth_Element.Data.ToResoniteLinkField());
members.Add("_expander", _expander_Element.Data.ToResoniteReference(context));
members.Add("_expanderIndicator", _expanderIndicator_Element.Data.ToResoniteReference(context));
members.Add("_slotNameText", _slotNameText_Element.Data.ToResoniteReference(context));
}

}
}
