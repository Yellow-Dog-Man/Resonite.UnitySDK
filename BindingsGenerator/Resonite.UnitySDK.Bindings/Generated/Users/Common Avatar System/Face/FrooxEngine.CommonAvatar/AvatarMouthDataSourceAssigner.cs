
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarMouthDataSourceAssigner
// Generated on: pátek 6. března 2026 14:19:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarMouthDataSourceAssigner")]
public partial class AvatarMouthDataSourceAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.SyncRef<global::FrooxEngine.IMouthTrackingSourceComponent> TargetReference { get => TargetReference_Element.Data; set => TargetReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.IMouthTrackingSourceComponent>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IMouthTrackingSourceComponent>> TargetReference_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetReference", TargetReference_Element.ToLinkReference(context));
}

}
}
