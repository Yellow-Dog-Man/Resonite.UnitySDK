
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldCloseDialog
// Generated on: pátek 13. února 2026 23:23:19
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_worldName", new ResoniteLink.Reference() { });
members.Add("_saveButton", new ResoniteLink.Reference() { });
members.Add("_saveAsButton", new ResoniteLink.Reference() { });
members.Add("_discardButton", new ResoniteLink.Reference() { });
members.Add("_saveAction", new ResoniteLink.Reference() { });
members.Add("_saveAsAction", new ResoniteLink.Reference() { });
members.Add("_discardAction", new ResoniteLink.Reference() { });
}

}
}
