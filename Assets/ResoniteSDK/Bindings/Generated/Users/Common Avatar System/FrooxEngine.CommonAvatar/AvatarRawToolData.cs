
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawToolData
// Generated on: pátek 13. února 2026 5:52:38
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawToolData")]
public partial class AvatarRawToolData : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::Renderite.Shared.Chirality ControllerSide;
public global::System.Boolean PressingPrimary;
public global::System.Boolean PressingSecondary;
public global::System.Boolean PressingGrab;
public global::System.Single PrimaryStrength;
public UnityEngine.Vector2 SecondaryAxis;
public global::FrooxEngine.User _activeUser;
public global::FrooxEngine.ValueStream<global::System.Single> _strengthStream;
public global::FrooxEngine.ValueStream<UnityEngine.Vector2> _axisStream;
public global::FrooxEngine.ValueStream<global::System.Boolean> _primaryStream;
public global::FrooxEngine.ValueStream<global::System.Boolean> _secondaryStream;
public global::FrooxEngine.ValueStream<global::System.Boolean> _grabStream;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ControllerSide", ControllerSide.ToResoniteLinkField());
members.Add("PressingPrimary", PressingPrimary.ToResoniteLinkField());
members.Add("PressingSecondary", PressingSecondary.ToResoniteLinkField());
members.Add("PressingGrab", PressingGrab.ToResoniteLinkField());
members.Add("PrimaryStrength", PrimaryStrength.ToResoniteLinkField());
members.Add("SecondaryAxis", SecondaryAxis.ToResoniteLinkField());
members.Add("_activeUser", new ResoniteLink.Reference() { });
members.Add("_strengthStream", new ResoniteLink.Reference() { });
members.Add("_axisStream", new ResoniteLink.Reference() { });
members.Add("_primaryStream", new ResoniteLink.Reference() { });
members.Add("_secondaryStream", new ResoniteLink.Reference() { });
members.Add("_grabStream", new ResoniteLink.Reference() { });
}

}
}
