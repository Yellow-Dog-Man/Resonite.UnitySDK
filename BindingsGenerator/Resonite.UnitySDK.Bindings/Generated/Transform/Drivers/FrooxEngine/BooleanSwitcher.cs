
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanSwitcher
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanSwitcher")]
public partial class BooleanSwitcher : global::FrooxEngine.AutoAddChildrenBase, global::FrooxEngine.ICustomInspector

{
    public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.FieldDrive<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>, Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>>> Targets = new();
public global::System.Int32 ActiveIndex { get => ActiveIndex_Element.Data; set => ActiveIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ActiveIndex_Element = new();
public global::FrooxEngine.BooleanSwitcher.Mode ActivationMode { get => ActivationMode_Element.Data; set => ActivationMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BooleanSwitcher.Mode>, global::FrooxEngine.BooleanSwitcher.Mode> ActivationMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Targets", new ResoniteLink.SyncList()
{
    Elements = Targets.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("ActiveIndex", ActiveIndex_Element.Data.ToResoniteLinkField());
members.Add("ActivationMode", ActivationMode_Element.Data.ToResoniteLinkField());
}

}
}
