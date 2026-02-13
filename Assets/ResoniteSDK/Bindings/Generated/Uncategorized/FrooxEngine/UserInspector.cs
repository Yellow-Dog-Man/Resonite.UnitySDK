
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInspector
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ViewUser", new ResoniteLink.Reference() { });
members.Add("ViewGroup", ViewGroup.ToResoniteLinkField());
members.Add("ViewStreamGroup", ViewStreamGroup.ToResoniteLinkField());
members.Add("_currentUser", new ResoniteLink.Reference() { });
members.Add("_currentViewGroup", _currentViewGroup.ToResoniteLinkField());
members.Add("_currentStreamGroup", _currentStreamGroup.ToResoniteLinkField());
members.Add("_userListContentRoot", new ResoniteLink.Reference() { });
members.Add("_workersContentRoot", new ResoniteLink.Reference() { });
members.Add("_userText", new ResoniteLink.Reference() { });
}

}
}
