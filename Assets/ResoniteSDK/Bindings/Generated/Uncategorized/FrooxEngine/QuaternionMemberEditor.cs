
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuaternionMemberEditor
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.QuaternionMemberEditor")]
public partial class QuaternionMemberEditor : global::FrooxEngine.MemberEditor

{
    public global::System.Boolean Vertical;
public global::FrooxEngine.TextEditor _xEditor;
public global::FrooxEngine.TextEditor _yEditor;
public global::FrooxEngine.TextEditor _zEditor;
public global::FrooxEngine.IField<global::System.String> _xDrive;
public global::FrooxEngine.IField<global::System.String> _yDrive;
public global::FrooxEngine.IField<global::System.String> _zDrive;
public global::FrooxEngine.UIX.Button _xButton;
public global::FrooxEngine.UIX.Button _yButton;
public global::FrooxEngine.UIX.Button _zButton;
public global::System.Nullable<UnityEngine.Vector3Double> _editingValue;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Vertical", Vertical.ToResoniteLinkField());
members.Add("_xEditor", new ResoniteLink.Reference() { });
members.Add("_yEditor", new ResoniteLink.Reference() { });
members.Add("_zEditor", new ResoniteLink.Reference() { });
members.Add("_xDrive", new ResoniteLink.Reference() { });
members.Add("_yDrive", new ResoniteLink.Reference() { });
members.Add("_zDrive", new ResoniteLink.Reference() { });
members.Add("_xButton", new ResoniteLink.Reference() { });
members.Add("_yButton", new ResoniteLink.Reference() { });
members.Add("_zButton", new ResoniteLink.Reference() { });
members.Add("_editingValue", _editingValue.ToResoniteLinkField());
}

}
}
