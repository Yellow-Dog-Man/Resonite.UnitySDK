
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BagEditor
// Generated on: čtvrtek 26. února 2026 10:04:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BagEditor")]
public partial class BagEditor : global::FrooxEngine.Component

{
    public global::FrooxEngine.ISyncBag _targetBag { get => _targetBag_Element.Data; set => _targetBag_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ISyncBag>, global::FrooxEngine.ISyncBag> _targetBag_Element = new();
public global::FrooxEngine.UIX.Button _addNewButton { get => _addNewButton_Element.Data; set => _addNewButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _addNewButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetBag", _targetBag_Element.Data.ToResoniteReference(context));
members.Add("_addNewButton", _addNewButton_Element.Data.ToResoniteReference(context));
}

}
}
