
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionItem
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SessionItem")]
public partial class SessionItem : global::FrooxEngine.CircleThumbnailItem

{
    public global::FrooxEngine.UIX.Text _sessionName { get => _sessionName_Element.Data; set => _sessionName_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _sessionName_Element = new();
public global::FrooxEngine.UIX.Text _sessionHost { get => _sessionHost_Element.Data; set => _sessionHost_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _sessionHost_Element = new();
public global::FrooxEngine.UIX.Text _userCount { get => _userCount_Element.Data; set => _userCount_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _userCount_Element = new();
public global::FrooxEngine.UIX.Button _joinButton { get => _joinButton_Element.Data; set => _joinButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _joinButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_sessionName", _sessionName_Element.ToLinkReference(context));
members.Add("_sessionHost", _sessionHost_Element.ToLinkReference(context));
members.Add("_userCount", _userCount_Element.ToLinkReference(context));
members.Add("_joinButton", _joinButton_Element.ToLinkReference(context));
}

}
}
