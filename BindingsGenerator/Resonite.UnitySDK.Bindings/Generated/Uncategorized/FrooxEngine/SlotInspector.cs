
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlotInspector
// Generated on: středa 25. února 2026 16:14:43
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
    public global::FrooxEngine.SyncRef<global::FrooxEngine.Slot> _selectionReference;
public global::FrooxEngine.Slot _rootSlot;
public global::FrooxEngine.Slot _childContainer;
public global::System.Int32 _depth;
public global::FrooxEngine.UIX.Expander _expander;
public global::FrooxEngine.UIX.TextExpandIndicator _expanderIndicator;
public global::FrooxEngine.UIX.Text _slotNameText;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_selectionReference", _selectionReference.ToResoniteReference(context));
members.Add("_rootSlot", _rootSlot.ToResoniteReference(context));
members.Add("_childContainer", _childContainer.ToResoniteReference(context));
members.Add("_depth", _depth.ToResoniteLinkField());
members.Add("_expander", _expander.ToResoniteReference(context));
members.Add("_expanderIndicator", _expanderIndicator.ToResoniteReference(context));
members.Add("_slotNameText", _slotNameText.ToResoniteReference(context));
}

}
}
