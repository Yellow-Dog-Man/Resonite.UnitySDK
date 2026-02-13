
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SliderMemberEditor
// Generated on: pátek 13. února 2026 23:23:18
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SliderMemberEditor")]
public partial class SliderMemberEditor : global::FrooxEngine.MemberEditor

{
    public global::FrooxEngine.UIX.Slider<global::System.Single> _slider;
public global::FrooxEngine.IField<global::System.Single> _sliderValue;
public global::FrooxEngine.PrimitiveMemberEditor _textEditor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_slider", new ResoniteLink.Reference() { });
members.Add("_sliderValue", new ResoniteLink.Reference() { });
members.Add("_textEditor", new ResoniteLink.Reference() { });
}

}
}
