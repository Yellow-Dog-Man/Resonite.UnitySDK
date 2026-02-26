
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarEyeTrackingInfo
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarEyeTrackingInfo")]
public partial class AvatarEyeTrackingInfo : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.IEyeDataSourceComponent EyeDataSource { get => EyeDataSource_Element.Data; set => EyeDataSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IEyeDataSourceComponent>, global::FrooxEngine.IEyeDataSourceComponent> EyeDataSource_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EyeDataSource", EyeDataSource_Element.ToLinkReference(context));
}

}
}
