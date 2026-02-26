
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EnumMemberEditor
// Generated on: čtvrtek 26. února 2026 15:09:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EnumMemberEditor")]
public partial class EnumMemberEditor : global::FrooxEngine.MemberEditor

{
    public global::FrooxEngine.IField<global::System.String> _textDrive { get => _textDrive_Element.Data; set => _textDrive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _textDrive_Element = new();
public global::FrooxEngine.UIX.Button _button { get => _button_Element.Data; set => _button_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _button_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_textDrive", _textDrive_Element.ToLinkReference(context));
members.Add("_button", _button_Element.ToLinkReference(context));
}

}
}
