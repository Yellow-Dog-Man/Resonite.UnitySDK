
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MigrationListUI
// Generated on: pátek 13. února 2026 23:23:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MigrationListUI")]
public partial class MigrationListUI : global::FrooxEngine.Component

{
    public global::System.String SelectedTaskId;
public global::FrooxEngine.Slot _listRoot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SelectedTaskId", SelectedTaskId.ToResoniteLinkField());
members.Add("_listRoot", new ResoniteLink.Reference() { });
}

}
}
