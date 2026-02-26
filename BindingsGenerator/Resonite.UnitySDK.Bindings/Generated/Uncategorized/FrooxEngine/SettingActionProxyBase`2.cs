
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SettingActionProxyBase<,>
// Generated on: čtvrtek 26. února 2026 15:09:14
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.String ActionName { get => ActionName_Element.Data; set => ActionName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ActionName_Element = new();
public global::System.String SubsettingGetter { get => SubsettingGetter_Element.Data; set => SubsettingGetter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SubsettingGetter_Element = new();
public global::System.String SubsettingKey { get => SubsettingKey_Element.Data; set => SubsettingKey_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> SubsettingKey_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ActionName", ActionName_Element.ToLinkField(context));
members.Add("SubsettingGetter", SubsettingGetter_Element.ToLinkField(context));
members.Add("SubsettingKey", SubsettingKey_Element.ToLinkField(context));
}

}
}
