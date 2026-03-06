
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarFingerPoseInfo
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarFingerPoseInfo")]
public partial class AvatarFingerPoseInfo : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.IFingerPoseSourceComponent FingerPoseSource { get => FingerPoseSource_Element.Data; set => FingerPoseSource_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IFingerPoseSourceComponent>, global::FrooxEngine.IFingerPoseSourceComponent> FingerPoseSource_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FingerPoseSource", FingerPoseSource_Element.ToLinkReference(context));
}

}
}
