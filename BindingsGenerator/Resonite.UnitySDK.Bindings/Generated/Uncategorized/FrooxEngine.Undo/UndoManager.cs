
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.UndoManager
// Generated on: čtvrtek 26. února 2026 10:04:48
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Undo
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.UndoManager")]
public partial class UndoManager : global::FrooxEngine.Component

{
    public global::System.Int32 MaxUndoSteps { get => MaxUndoSteps_Element.Data; set => MaxUndoSteps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxUndoSteps_Element = new();
public global::System.Boolean UnsavedChanges { get => UnsavedChanges_Element.Data; set => UnsavedChanges_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UnsavedChanges_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxUndoSteps", MaxUndoSteps_Element.Data.ToResoniteLinkField());
members.Add("UnsavedChanges", UnsavedChanges_Element.Data.ToResoniteLinkField());
}

}
}
