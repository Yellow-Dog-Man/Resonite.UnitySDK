
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceScreensManager
// Generated on: úterý 24. února 2026 18:20:30
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserspaceScreensManager")]
public partial class UserspaceScreensManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserLoginStatus _loginStatus;
public global::FrooxEngine.UIX.Text _unreadIndicator;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_loginStatus", _loginStatus.ToResoniteReference(context));
members.Add("_unreadIndicator", _unreadIndicator.ToResoniteReference(context));
}

}
}
