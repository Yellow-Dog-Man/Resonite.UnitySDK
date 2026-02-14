
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchorLocomotionRelease
// Generated on: sobota 14. února 2026 8:58:50
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchorLocomotionRelease")]
public partial class AvatarAnchorLocomotionRelease : global::FrooxEngine.Component, global::FrooxEngine.IInputUpdateReceiver

{
    public global::System.Boolean ReleaseOnBinaryAction;
public global::System.Nullable<global::System.Single> ReleaseStrengthThreshold;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReleaseOnBinaryAction", ReleaseOnBinaryAction.ToResoniteLinkField());
members.Add("ReleaseStrengthThreshold", ReleaseStrengthThreshold.ToResoniteLinkField());
}

}
}
