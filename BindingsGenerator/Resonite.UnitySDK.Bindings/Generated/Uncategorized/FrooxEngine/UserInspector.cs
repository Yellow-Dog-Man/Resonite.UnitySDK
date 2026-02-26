
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserInspector
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserInspector")]
public partial class UserInspector : global::FrooxEngine.InspectorPanel, global::FrooxEngine.Undo.INoDestroyUndo

{
    public global::FrooxEngine.User ViewUser { get => ViewUser_Element.Data; set => ViewUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> ViewUser_Element = new();
public global::FrooxEngine.UserInspector.View ViewGroup { get => ViewGroup_Element.Data; set => ViewGroup_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserInspector.View>, global::FrooxEngine.UserInspector.View> ViewGroup_Element = new();
public global::System.UInt16 ViewStreamGroup { get => ViewStreamGroup_Element.Data; set => ViewStreamGroup_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.UInt16>, global::System.UInt16> ViewStreamGroup_Element = new();
public global::FrooxEngine.User _currentUser { get => _currentUser_Element.Data; set => _currentUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> _currentUser_Element = new();
public global::FrooxEngine.UserInspector.View _currentViewGroup { get => _currentViewGroup_Element.Data; set => _currentViewGroup_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserInspector.View>, global::FrooxEngine.UserInspector.View> _currentViewGroup_Element = new();
public global::System.UInt16 _currentStreamGroup { get => _currentStreamGroup_Element.Data; set => _currentStreamGroup_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.UInt16>, global::System.UInt16> _currentStreamGroup_Element = new();
public global::FrooxEngine.Slot _userListContentRoot { get => _userListContentRoot_Element.Data; set => _userListContentRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _userListContentRoot_Element = new();
public global::FrooxEngine.Slot _workersContentRoot { get => _workersContentRoot_Element.Data; set => _workersContentRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _workersContentRoot_Element = new();
public global::FrooxEngine.Sync<global::System.String> _userText { get => _userText_Element.Data; set => _userText_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Sync<global::System.String>>, global::FrooxEngine.Sync<global::System.String>> _userText_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ViewUser", ViewUser_Element.ToLinkReference(context));
members.Add("ViewGroup", ViewGroup_Element.ToLinkField(context));
members.Add("ViewStreamGroup", ViewStreamGroup_Element.ToLinkField(context));
members.Add("_currentUser", _currentUser_Element.ToLinkReference(context));
members.Add("_currentViewGroup", _currentViewGroup_Element.ToLinkField(context));
members.Add("_currentStreamGroup", _currentStreamGroup_Element.ToLinkField(context));
members.Add("_userListContentRoot", _userListContentRoot_Element.ToLinkReference(context));
members.Add("_workersContentRoot", _workersContentRoot_Element.ToLinkReference(context));
members.Add("_userText", _userText_Element.ToLinkReference(context));
}

}
}
