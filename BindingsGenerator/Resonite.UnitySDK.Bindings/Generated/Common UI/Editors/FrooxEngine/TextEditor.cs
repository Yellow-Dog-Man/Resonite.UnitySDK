
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextEditor
// Generated on: čtvrtek 26. února 2026 12:26:53
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextEditor")]
public partial class TextEditor : global::FrooxEngine.Component, global::FrooxEngine.IFocusable

{
    public global::FrooxEngine.IText Text { get => Text_Element.Data; set => Text_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IText>, global::FrooxEngine.IText> Text_Element = new();
public global::System.Boolean Undo { get => Undo_Element.Data; set => Undo_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Undo_Element = new();
public global::System.String UndoDescription { get => UndoDescription_Element.Data; set => UndoDescription_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> UndoDescription_Element = new();
public global::FrooxEngine.TextEditor.FinishAction FinishHandling { get => FinishHandling_Element.Data; set => FinishHandling_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.TextEditor.FinishAction>, global::FrooxEngine.TextEditor.FinishAction> FinishHandling_Element = new();
public global::System.Boolean AutoCaretColorField { get => AutoCaretColorField_Element.Data; set => AutoCaretColorField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoCaretColorField_Element = new();
public UnityEngine.ColorX CaretColorField { get => CaretColorField_Element.Data; set => CaretColorField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> CaretColorField_Element = new();
public UnityEngine.ColorX SelectionColorField { get => SelectionColorField_Element.Data; set => SelectionColorField_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> SelectionColorField_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Text", Text_Element.ToLinkReference(context));
members.Add("Undo", Undo_Element.ToLinkField(context));
members.Add("UndoDescription", UndoDescription_Element.ToLinkField(context));
members.Add("FinishHandling", FinishHandling_Element.ToLinkField(context));
members.Add("AutoCaretColorField", AutoCaretColorField_Element.ToLinkField(context));
members.Add("CaretColorField", CaretColorField_Element.ToLinkField(context));
members.Add("SelectionColorField", SelectionColorField_Element.ToLinkField(context));
}

}
}
