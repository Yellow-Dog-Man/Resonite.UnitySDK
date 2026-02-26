
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PrimitiveMemberEditor
// Generated on: čtvrtek 26. února 2026 15:09:13
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PrimitiveMemberEditor")]
public partial class PrimitiveMemberEditor : global::FrooxEngine.MemberEditor

{
    public global::System.String Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Format_Element = new();
public global::FrooxEngine.TextEditor _textEditor { get => _textEditor_Element.Data; set => _textEditor_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextEditor>, global::FrooxEngine.TextEditor> _textEditor_Element = new();
public global::FrooxEngine.IField<global::System.String> _textDrive { get => _textDrive_Element.Data; set => _textDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _textDrive_Element = new();
public global::FrooxEngine.UIX.Button _button { get => _button_Element.Data; set => _button_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _button_Element = new();
public global::FrooxEngine.UIX.Button _resetButton { get => _resetButton_Element.Data; set => _resetButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _resetButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Format", Format_Element.ToLinkField(context));
members.Add("_textEditor", _textEditor_Element.ToLinkReference(context));
members.Add("_textDrive", _textDrive_Element.ToLinkReference(context));
members.Add("_button", _button_Element.ToLinkReference(context));
members.Add("_resetButton", _resetButton_Element.ToLinkReference(context));
}

}
}
