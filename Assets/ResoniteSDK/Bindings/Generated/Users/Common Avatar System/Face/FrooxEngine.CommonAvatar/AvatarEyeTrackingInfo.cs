
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarEyeTrackingInfo
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarEyeTrackingInfo")]
public partial class AvatarEyeTrackingInfo : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.IEyeDataSourceComponent EyeDataSource;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EyeDataSource", EyeDataSource.ToResoniteReference(context));
}

}
}
