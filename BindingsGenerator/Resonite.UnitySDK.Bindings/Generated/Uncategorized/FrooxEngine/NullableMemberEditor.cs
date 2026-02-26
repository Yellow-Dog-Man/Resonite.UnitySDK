
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NullableMemberEditor
// Generated on: čtvrtek 26. února 2026 10:04:47
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NullableMemberEditor")]
public partial class NullableMemberEditor : global::FrooxEngine.MemberEditor

{
    public System.String NullableBaseType { get => NullableBaseType_Element.Data; set => NullableBaseType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> NullableBaseType_Element = new();
public global::FrooxEngine.UIX.Checkbox _checkBox { get => _checkBox_Element.Data; set => _checkBox_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _checkBox_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _stateDrive { get => _stateDrive_Element.Data; set => _stateDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _stateDrive_Element = new();
public global::FrooxEngine.UIX.Button _button { get => _button_Element.Data; set => _button_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _button_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NullableBaseType", NullableBaseType_Element.Data.ToResoniteLinkField());
members.Add("_checkBox", _checkBox_Element.Data.ToResoniteReference(context));
members.Add("_stateDrive", _stateDrive_Element.Data.ToResoniteReference(context));
members.Add("_button", _button_Element.Data.ToResoniteReference(context));
}

}
}
