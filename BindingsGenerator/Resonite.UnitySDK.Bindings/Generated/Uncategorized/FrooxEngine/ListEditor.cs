
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ListEditor
// Generated on: čtvrtek 26. února 2026 12:28:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ListEditor")]
public partial class ListEditor : global::FrooxEngine.Component

{
    public global::FrooxEngine.ISyncList _targetList { get => _targetList_Element.Data; set => _targetList_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ISyncList>, global::FrooxEngine.ISyncList> _targetList_Element = new();
public global::FrooxEngine.UIX.Button _addNewButton { get => _addNewButton_Element.Data; set => _addNewButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _addNewButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetList", _targetList_Element.ToLinkReference(context));
members.Add("_addNewButton", _addNewButton_Element.ToLinkReference(context));
}

}
}
