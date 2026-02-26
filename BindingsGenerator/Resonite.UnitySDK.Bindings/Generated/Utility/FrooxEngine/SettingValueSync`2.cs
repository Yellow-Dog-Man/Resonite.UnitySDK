
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SettingValueSync<,>
// Generated on: čtvrtek 26. února 2026 12:28:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SettingValueSync<,>")]
public partial class SettingValueSync<T,S> : global::FrooxEngine.Component
	where S : global::FrooxEngine.SettingComponent<S>
	

{
    public global::FrooxEngine.UserRef SyncingUser = new();
public global::System.String SettingName { get => SettingName_Element.Data; set => SettingName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SettingName_Element = new();
public global::FrooxEngine.IField<T> TargetField { get => TargetField_Element.Data; set => TargetField_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> TargetField_Element = new();
public global::System.String SubsettingGetter { get => SubsettingGetter_Element.Data; set => SubsettingGetter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SubsettingGetter_Element = new();
public global::System.String SubsettingKey { get => SubsettingKey_Element.Data; set => SubsettingKey_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SubsettingKey_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SyncingUser", SyncingUser.ToLinkSyncObject(context));
members.Add("SettingName", SettingName_Element.ToLinkField(context));
members.Add("TargetField", TargetField_Element.ToLinkReference(context));
members.Add("SubsettingGetter", SubsettingGetter_Element.ToLinkField(context));
members.Add("SubsettingKey", SubsettingKey_Element.ToLinkField(context));
}

}
}
