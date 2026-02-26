
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SliderMemberEditor
// Generated on: čtvrtek 26. února 2026 12:28:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SliderMemberEditor")]
public partial class SliderMemberEditor : global::FrooxEngine.MemberEditor

{
    public global::FrooxEngine.UIX.Slider<global::System.Single> _slider { get => _slider_Element.Data; set => _slider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Slider<global::System.Single>>, global::FrooxEngine.UIX.Slider<global::System.Single>> _slider_Element = new();
public global::FrooxEngine.IField<global::System.Single> _sliderValue { get => _sliderValue_Element.Data; set => _sliderValue_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _sliderValue_Element = new();
public global::FrooxEngine.PrimitiveMemberEditor _textEditor { get => _textEditor_Element.Data; set => _textEditor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PrimitiveMemberEditor>, global::FrooxEngine.PrimitiveMemberEditor> _textEditor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_slider", _slider_Element.ToLinkReference(context));
members.Add("_sliderValue", _sliderValue_Element.ToLinkReference(context));
members.Add("_textEditor", _textEditor_Element.ToLinkReference(context));
}

}
}
