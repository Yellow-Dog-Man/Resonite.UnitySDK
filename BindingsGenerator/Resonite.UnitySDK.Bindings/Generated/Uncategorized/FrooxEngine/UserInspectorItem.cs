
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInspectorItem
// Generated on: čtvrtek 26. února 2026 15:09:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserInspectorItem")]
public partial class UserInspectorItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.User _user { get => _user_Element.Data; set => _user_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _user_Element = new();
public global::FrooxEngine.UIX.Text _userNameText { get => _userNameText_Element.Data; set => _userNameText_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _userNameText_Element = new();
public global::FrooxEngine.UIX.Expander _expander { get => _expander_Element.Data; set => _expander_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Expander>, global::FrooxEngine.UIX.Expander> _expander_Element = new();
public global::FrooxEngine.UIX.TextExpandIndicator _expanderIndicator { get => _expanderIndicator_Element.Data; set => _expanderIndicator_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextExpandIndicator>, global::FrooxEngine.UIX.TextExpandIndicator> _expanderIndicator_Element = new();
public global::FrooxEngine.Slot _childContainer { get => _childContainer_Element.Data; set => _childContainer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _childContainer_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_user", _user_Element.ToLinkReference(context));
members.Add("_userNameText", _userNameText_Element.ToLinkReference(context));
members.Add("_expander", _expander_Element.ToLinkReference(context));
members.Add("_expanderIndicator", _expanderIndicator_Element.ToLinkReference(context));
members.Add("_childContainer", _childContainer_Element.ToLinkReference(context));
}

}
}
