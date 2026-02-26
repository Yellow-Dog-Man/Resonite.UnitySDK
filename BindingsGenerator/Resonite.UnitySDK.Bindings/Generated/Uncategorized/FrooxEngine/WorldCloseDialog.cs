
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldCloseDialog
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldCloseDialog")]
public partial class WorldCloseDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.Text _worldName { get => _worldName_Element.Data; set => _worldName_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _worldName_Element = new();
public global::FrooxEngine.UIX.Button _saveButton { get => _saveButton_Element.Data; set => _saveButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _saveButton_Element = new();
public global::FrooxEngine.UIX.Button _saveAsButton { get => _saveAsButton_Element.Data; set => _saveAsButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _saveAsButton_Element = new();
public global::FrooxEngine.UIX.Button _discardButton { get => _discardButton_Element.Data; set => _discardButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _discardButton_Element = new();
public global::FrooxEngine.WorldCloseAction _saveAction { get => _saveAction_Element.Data; set => _saveAction_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldCloseAction>, global::FrooxEngine.WorldCloseAction> _saveAction_Element = new();
public global::FrooxEngine.WorldCloseAction _saveAsAction { get => _saveAsAction_Element.Data; set => _saveAsAction_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldCloseAction>, global::FrooxEngine.WorldCloseAction> _saveAsAction_Element = new();
public global::FrooxEngine.WorldCloseAction _discardAction { get => _discardAction_Element.Data; set => _discardAction_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldCloseAction>, global::FrooxEngine.WorldCloseAction> _discardAction_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_worldName", _worldName_Element.Data.ToResoniteReference(context));
members.Add("_saveButton", _saveButton_Element.Data.ToResoniteReference(context));
members.Add("_saveAsButton", _saveAsButton_Element.Data.ToResoniteReference(context));
members.Add("_discardButton", _discardButton_Element.Data.ToResoniteReference(context));
members.Add("_saveAction", _saveAction_Element.Data.ToResoniteReference(context));
members.Add("_saveAsAction", _saveAsAction_Element.Data.ToResoniteReference(context));
members.Add("_discardAction", _discardAction_Element.Data.ToResoniteReference(context));
}

}
}
