
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.UndoManager
// Generated on: úterý 24. února 2026 18:20:29
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::System.Int32 MaxUndoSteps;
public global::System.Boolean UnsavedChanges;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxUndoSteps", MaxUndoSteps.ToResoniteLinkField());
members.Add("UnsavedChanges", UnsavedChanges.ToResoniteLinkField());
}

}
}
