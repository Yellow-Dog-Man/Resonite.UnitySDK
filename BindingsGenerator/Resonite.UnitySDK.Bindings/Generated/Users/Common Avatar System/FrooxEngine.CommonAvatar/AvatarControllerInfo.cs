
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarControllerInfo
// Generated on: pátek 6. března 2026 14:19:11
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.User TargetUser { get => TargetUser_Element.Data; set => TargetUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> TargetUser_Element = new();
public global::Renderite.Shared.Chirality ControllerSide { get => ControllerSide_Element.Data; set => ControllerSide_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> ControllerSide_Element = new();
public System.String ControllerType { get => ControllerType_Element.Data; set => ControllerType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> ControllerType_Element = new();
public global::System.String ControllerDeviceModel { get => ControllerDeviceModel_Element.Data; set => ControllerDeviceModel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ControllerDeviceModel_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", TargetUser_Element.ToLinkReference(context));
members.Add("ControllerSide", ControllerSide_Element.ToLinkField(context));
members.Add("ControllerType", ControllerType_Element.ToLinkField(context));
members.Add("ControllerDeviceModel", ControllerDeviceModel_Element.ToLinkField(context));
}

}
}
