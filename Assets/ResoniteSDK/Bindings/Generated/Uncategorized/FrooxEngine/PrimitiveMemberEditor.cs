
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PrimitiveMemberEditor
// Generated on: úterý 24. února 2026 18:20:26
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PrimitiveMemberEditor")]
public partial class PrimitiveMemberEditor : global::FrooxEngine.MemberEditor

{
    public global::System.String Format;
public global::FrooxEngine.TextEditor _textEditor;
public global::FrooxEngine.IField<global::System.String> _textDrive;
public global::FrooxEngine.UIX.Button _button;
public global::FrooxEngine.UIX.Button _resetButton;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Format", Format.ToResoniteLinkField());
members.Add("_textEditor", _textEditor.ToResoniteReference(context));
members.Add("_textDrive", _textDrive.ToResoniteReference(context));
members.Add("_button", _button.ToResoniteReference(context));
members.Add("_resetButton", _resetButton.ToResoniteReference(context));
}

}
}
