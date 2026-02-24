
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldCloseDialog
// Generated on: úterý 24. února 2026 18:20:30
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.UIX.Text _worldName;
public global::FrooxEngine.UIX.Button _saveButton;
public global::FrooxEngine.UIX.Button _saveAsButton;
public global::FrooxEngine.UIX.Button _discardButton;
public global::FrooxEngine.WorldCloseAction _saveAction;
public global::FrooxEngine.WorldCloseAction _saveAsAction;
public global::FrooxEngine.WorldCloseAction _discardAction;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_worldName", _worldName.ToResoniteReference(context));
members.Add("_saveButton", _saveButton.ToResoniteReference(context));
members.Add("_saveAsButton", _saveAsButton.ToResoniteReference(context));
members.Add("_discardButton", _discardButton.ToResoniteReference(context));
members.Add("_saveAction", _saveAction.ToResoniteReference(context));
members.Add("_saveAsAction", _saveAsAction.ToResoniteReference(context));
members.Add("_discardAction", _discardAction.ToResoniteReference(context));
}

}
}
