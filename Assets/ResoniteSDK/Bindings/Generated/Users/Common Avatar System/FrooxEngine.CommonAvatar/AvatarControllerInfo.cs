
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarControllerInfo
// Generated on: čtvrtek 19. února 2026 8:00:32
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarControllerInfo")]
public partial class AvatarControllerInfo : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.User TargetUser;
public global::Renderite.Shared.Chirality ControllerSide;
public System.String ControllerType;
public global::System.String ControllerDeviceModel;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", TargetUser.ToResoniteReference(context));
members.Add("ControllerSide", ControllerSide.ToResoniteLinkField());
members.Add("ControllerType", ControllerType.ToResoniteLinkField());
members.Add("ControllerDeviceModel", ControllerDeviceModel.ToResoniteLinkField());
}

}
}
