
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionItem
// Generated on: úterý 24. února 2026 18:20:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SessionItem")]
public partial class SessionItem : global::FrooxEngine.CircleThumbnailItem

{
    public global::FrooxEngine.UIX.Text _sessionName;
public global::FrooxEngine.UIX.Text _sessionHost;
public global::FrooxEngine.UIX.Text _userCount;
public global::FrooxEngine.UIX.Button _joinButton;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_sessionName", _sessionName.ToResoniteReference(context));
members.Add("_sessionHost", _sessionHost.ToResoniteReference(context));
members.Add("_userCount", _userCount.ToResoniteReference(context));
members.Add("_joinButton", _joinButton.ToResoniteReference(context));
}

}
}
