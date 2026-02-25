
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchorLocomotionRelease
// Generated on: středa 25. února 2026 16:14:45
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
