
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NullableMemberEditor
// Generated on: sobota 14. února 2026 8:58:46
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NullableMemberEditor")]
public partial class NullableMemberEditor : global::FrooxEngine.MemberEditor

{
    public System.String NullableBaseType;
public global::FrooxEngine.UIX.Checkbox _checkBox;
public global::FrooxEngine.IField<global::System.Boolean> _stateDrive;
public global::FrooxEngine.UIX.Button _button;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NullableBaseType", NullableBaseType.ToResoniteLinkField());
members.Add("_checkBox", _checkBox.ToResoniteReference(context));
members.Add("_stateDrive", _stateDrive.ToResoniteReference(context));
members.Add("_button", _button.ToResoniteReference(context));
}

}
}
