
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.QuaternionMemberEditor
// Generated on: úterý 24. února 2026 18:20:27
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Vertical", Vertical.ToResoniteLinkField());
members.Add("_xEditor", _xEditor.ToResoniteReference(context));
members.Add("_yEditor", _yEditor.ToResoniteReference(context));
members.Add("_zEditor", _zEditor.ToResoniteReference(context));
members.Add("_xDrive", _xDrive.ToResoniteReference(context));
members.Add("_yDrive", _yDrive.ToResoniteReference(context));
members.Add("_zDrive", _zDrive.ToResoniteReference(context));
members.Add("_xButton", _xButton.ToResoniteReference(context));
members.Add("_yButton", _yButton.ToResoniteReference(context));
members.Add("_zButton", _zButton.ToResoniteReference(context));
members.Add("_editingValue", _editingValue.ToResoniteLinkField());
}

}
}
