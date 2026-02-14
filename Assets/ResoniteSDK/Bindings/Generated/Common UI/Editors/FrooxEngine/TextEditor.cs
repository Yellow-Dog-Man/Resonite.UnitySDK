
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextEditor
// Generated on: sobota 14. února 2026 8:57:04
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextEditor")]
public partial class TextEditor : global::FrooxEngine.Component, global::FrooxEngine.IFocusable

{
    public global::FrooxEngine.IText Text;
public global::System.Boolean Undo;
public global::System.String UndoDescription;
public global::FrooxEngine.TextEditor.FinishAction FinishHandling;
public global::System.Boolean AutoCaretColorField;
public UnityEngine.ColorX CaretColorField;
public UnityEngine.ColorX SelectionColorField;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Text", Text.ToResoniteReference(context));
members.Add("Undo", Undo.ToResoniteLinkField());
members.Add("UndoDescription", UndoDescription.ToResoniteLinkField());
members.Add("FinishHandling", FinishHandling.ToResoniteLinkField());
members.Add("AutoCaretColorField", AutoCaretColorField.ToResoniteLinkField());
members.Add("CaretColorField", CaretColorField.ToResoniteLinkField());
members.Add("SelectionColorField", SelectionColorField.ToResoniteLinkField());
}

}
}
