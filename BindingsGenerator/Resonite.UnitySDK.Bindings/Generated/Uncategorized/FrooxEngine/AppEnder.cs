
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AppEnder
// Generated on: čtvrtek 26. února 2026 15:09:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AppEnder")]
public partial class AppEnder : global::FrooxEngine.Component

{
    public global::FrooxEngine.AppEnder.EndMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AppEnder.EndMode>, global::FrooxEngine.AppEnder.EndMode> Mode_Element = new();
public global::System.Boolean ChangesSaved { get => ChangesSaved_Element.Data; set => ChangesSaved_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ChangesSaved_Element = new();
public global::FrooxEngine.TextRenderer _text { get => _text_Element.Data; set => _text_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _text_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _textColor { get => _textColor_Element.Data; set => _textColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _textColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _outlineColor { get => _outlineColor_Element.Data; set => _outlineColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _outlineColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("ChangesSaved", ChangesSaved_Element.ToLinkField(context));
members.Add("_text", _text_Element.ToLinkReference(context));
members.Add("_textColor", _textColor_Element.ToLinkReference(context));
members.Add("_outlineColor", _outlineColor_Element.ToLinkReference(context));
}

}
}
