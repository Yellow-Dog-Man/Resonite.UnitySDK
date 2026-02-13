
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInspectorItem
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserInspectorItem")]
public partial class UserInspectorItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.User _user;
public global::FrooxEngine.UIX.Text _userNameText;
public global::FrooxEngine.UIX.Expander _expander;
public global::FrooxEngine.UIX.TextExpandIndicator _expanderIndicator;
public global::FrooxEngine.Slot _childContainer;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_user", new ResoniteLink.Reference() { });
members.Add("_userNameText", new ResoniteLink.Reference() { });
members.Add("_expander", new ResoniteLink.Reference() { });
members.Add("_expanderIndicator", new ResoniteLink.Reference() { });
members.Add("_childContainer", new ResoniteLink.Reference() { });
}

}
}
