
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MigrationListUI
// Generated on: úterý 24. února 2026 18:20:25
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MigrationListUI")]
public partial class MigrationListUI : global::FrooxEngine.Component

{
    public global::System.String SelectedTaskId;
public global::FrooxEngine.Slot _listRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedTaskId", SelectedTaskId.ToResoniteLinkField());
members.Add("_listRoot", _listRoot.ToResoniteReference(context));
}

}
}
