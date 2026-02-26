
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarMouthTrackingInfo
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarMouthTrackingInfo")]
public partial class AvatarMouthTrackingInfo : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.IMouthTrackingSourceComponent MouthDataSource { get => MouthDataSource_Element.Data; set => MouthDataSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IMouthTrackingSourceComponent>, global::FrooxEngine.IMouthTrackingSourceComponent> MouthDataSource_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MouthDataSource", MouthDataSource_Element.Data.ToResoniteReference(context));
}

}
}
