
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SettingActionProxyBase<,>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SettingActionProxyBase<,>")]
public abstract partial class SettingActionProxyBase<S,D> : global::FrooxEngine.Component
	where D : global::System.Delegate
	where S : global::FrooxEngine.SettingComponent<S>

{
    public global::System.String ActionName;
public global::System.String SubsettingGetter;
public global::System.String SubsettingKey;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ActionName", ActionName.ToResoniteLinkField());
members.Add("SubsettingGetter", SubsettingGetter.ToResoniteLinkField());
members.Add("SubsettingKey", SubsettingKey.ToResoniteLinkField());
}

}
}
