
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceScreensManager
// Generated on: čtvrtek 26. února 2026 10:04:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserspaceScreensManager")]
public partial class UserspaceScreensManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserLoginStatus _loginStatus { get => _loginStatus_Element.Data; set => _loginStatus_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UserLoginStatus>, global::FrooxEngine.UserLoginStatus> _loginStatus_Element = new();
public global::FrooxEngine.UIX.Text _unreadIndicator { get => _unreadIndicator_Element.Data; set => _unreadIndicator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _unreadIndicator_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_loginStatus", _loginStatus_Element.Data.ToResoniteReference(context));
members.Add("_unreadIndicator", _unreadIndicator_Element.Data.ToResoniteReference(context));
}

}
}
