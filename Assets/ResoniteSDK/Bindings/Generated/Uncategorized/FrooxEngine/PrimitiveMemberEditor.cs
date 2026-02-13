
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PrimitiveMemberEditor
// Generated on: pátek 13. února 2026 5:52:35
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PrimitiveMemberEditor")]
public partial class PrimitiveMemberEditor : global::FrooxEngine.MemberEditor

{
    public global::System.String Format;
public global::FrooxEngine.TextEditor _textEditor;
public global::FrooxEngine.IField<global::System.String> _textDrive;
public global::FrooxEngine.UIX.Button _button;
public global::FrooxEngine.UIX.Button _resetButton;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Format", Format.ToResoniteLinkField());
members.Add("_textEditor", new ResoniteLink.Reference() { });
members.Add("_textDrive", new ResoniteLink.Reference() { });
members.Add("_button", new ResoniteLink.Reference() { });
members.Add("_resetButton", new ResoniteLink.Reference() { });
}

}
}
