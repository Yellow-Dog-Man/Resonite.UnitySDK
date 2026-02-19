
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInspectorItem
// Generated on: čtvrtek 19. února 2026 8:00:31
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_user", _user.ToResoniteReference(context));
members.Add("_userNameText", _userNameText.ToResoniteReference(context));
members.Add("_expander", _expander.ToResoniteReference(context));
members.Add("_expanderIndicator", _expanderIndicator.ToResoniteReference(context));
members.Add("_childContainer", _childContainer.ToResoniteReference(context));
}

}
}
