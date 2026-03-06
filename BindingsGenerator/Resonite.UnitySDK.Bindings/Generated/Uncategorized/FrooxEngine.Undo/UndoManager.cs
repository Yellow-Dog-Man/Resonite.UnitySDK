
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.UndoManager
// Generated on: pátek 6. března 2026 14:19:11
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
members.Add("MaxUndoSteps", MaxUndoSteps_Element.ToLinkField(context));
members.Add("UnsavedChanges", UnsavedChanges_Element.ToLinkField(context));
}

}
}
