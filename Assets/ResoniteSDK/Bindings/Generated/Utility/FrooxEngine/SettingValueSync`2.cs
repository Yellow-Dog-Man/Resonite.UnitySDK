
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SettingValueSync<,>
// Generated on: sobota 14. února 2026 8:58:51
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SettingValueSync<,>")]
public partial class SettingValueSync<T,S> : global::FrooxEngine.Component
	where S : global::FrooxEngine.SettingComponent<S>
	

{
    public global::FrooxEngine.UserRef SyncingUser;
public global::System.String SettingName;
public global::FrooxEngine.IField<T> TargetField;
public global::System.String SubsettingGetter;
public global::System.String SubsettingKey;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SyncingUser", new ResoniteLink.SyncObject() { Members = SyncingUser.CollectMembers(context) });
members.Add("SettingName", SettingName.ToResoniteLinkField());
members.Add("TargetField", TargetField.ToResoniteReference(context));
members.Add("SubsettingGetter", SubsettingGetter.ToResoniteLinkField());
members.Add("SubsettingKey", SubsettingKey.ToResoniteLinkField());
}

}
}
