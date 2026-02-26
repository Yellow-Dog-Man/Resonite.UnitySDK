
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MigrationListUI
// Generated on: čtvrtek 26. února 2026 12:28:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MigrationListUI")]
public partial class MigrationListUI : global::FrooxEngine.Component

{
    public global::System.String SelectedTaskId { get => SelectedTaskId_Element.Data; set => SelectedTaskId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SelectedTaskId_Element = new();
public global::FrooxEngine.Slot _listRoot { get => _listRoot_Element.Data; set => _listRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _listRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedTaskId", SelectedTaskId_Element.ToLinkField(context));
members.Add("_listRoot", _listRoot_Element.ToLinkReference(context));
}

}
}
