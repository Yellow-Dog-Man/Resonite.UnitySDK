
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInspector
// Generated on: úterý 24. února 2026 18:20:29
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserInspector")]
public partial class UserInspector : global::FrooxEngine.InspectorPanel, global::FrooxEngine.Undo.INoDestroyUndo

{
    public global::FrooxEngine.User ViewUser;
public global::FrooxEngine.UserInspector.View ViewGroup;
public global::System.UInt16 ViewStreamGroup;
public global::FrooxEngine.User _currentUser;
public global::FrooxEngine.UserInspector.View _currentViewGroup;
public global::System.UInt16 _currentStreamGroup;
public global::FrooxEngine.Slot _userListContentRoot;
public global::FrooxEngine.Slot _workersContentRoot;
public global::FrooxEngine.Sync<global::System.String> _userText;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ViewUser", ViewUser.ToResoniteReference(context));
members.Add("ViewGroup", ViewGroup.ToResoniteLinkField());
members.Add("ViewStreamGroup", ViewStreamGroup.ToResoniteLinkField());
members.Add("_currentUser", _currentUser.ToResoniteReference(context));
members.Add("_currentViewGroup", _currentViewGroup.ToResoniteLinkField());
members.Add("_currentStreamGroup", _currentStreamGroup.ToResoniteLinkField());
members.Add("_userListContentRoot", _userListContentRoot.ToResoniteReference(context));
members.Add("_workersContentRoot", _workersContentRoot.ToResoniteReference(context));
members.Add("_userText", _userText.ToResoniteReference(context));
}

}
}
