
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SliderMemberEditor
// Generated on: úterý 24. února 2026 18:20:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SliderMemberEditor")]
public partial class SliderMemberEditor : global::FrooxEngine.MemberEditor

{
    public global::FrooxEngine.UIX.Slider<global::System.Single> _slider;
public global::FrooxEngine.IField<global::System.Single> _sliderValue;
public global::FrooxEngine.PrimitiveMemberEditor _textEditor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_slider", _slider.ToResoniteReference(context));
members.Add("_sliderValue", _sliderValue.ToResoniteReference(context));
members.Add("_textEditor", _textEditor.ToResoniteReference(context));
}

}
}
