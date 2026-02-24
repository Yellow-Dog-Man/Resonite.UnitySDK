
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawEyeData
// Generated on: úterý 24. února 2026 18:20:32
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawEyeData")]
public partial class AvatarRawEyeData : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.CommonAvatar.AvatarRawEyeData.EyeData LeftEye;
public global::FrooxEngine.CommonAvatar.AvatarRawEyeData.EyeData RightEye;
public global::FrooxEngine.CommonAvatar.AvatarRawEyeData.EyeData CombinedEye;
public global::System.Single ConvergenceDistance;
public global::System.Double Timestamp;
public global::FrooxEngine.User _activeUser;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LeftEye", new ResoniteLink.SyncObject() { Members = LeftEye.CollectMembers(context) });
members.Add("RightEye", new ResoniteLink.SyncObject() { Members = RightEye.CollectMembers(context) });
members.Add("CombinedEye", new ResoniteLink.SyncObject() { Members = CombinedEye.CollectMembers(context) });
members.Add("ConvergenceDistance", ConvergenceDistance.ToResoniteLinkField());
members.Add("Timestamp", Timestamp.ToResoniteLinkField());
members.Add("_activeUser", _activeUser.ToResoniteReference(context));
}

}
}
