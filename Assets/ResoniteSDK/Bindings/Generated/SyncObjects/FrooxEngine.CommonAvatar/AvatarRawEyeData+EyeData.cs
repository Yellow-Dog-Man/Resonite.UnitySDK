
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawEyeData+EyeData
// Generated on: pátek 13. února 2026 23:23:20
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    public partial class AvatarRawEyeData
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawEyeData+EyeData")]
public partial class EyeData : global::FrooxEngine.SyncObject

{
    public global::System.Boolean IsTracking;
public UnityEngine.Vector3 Origin;
public UnityEngine.Vector3 Direction;
public global::System.Single PupilDiameter;
public global::System.Single Openness;
public global::System.Single Widen;
public global::System.Single Squeeze;
public global::System.Single Frown;
public global::System.Single InnerBrowVertical;
public global::System.Single OuterBrowVertical;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsTracking", IsTracking.ToResoniteLinkField());
members.Add("Origin", Origin.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("PupilDiameter", PupilDiameter.ToResoniteLinkField());
members.Add("Openness", Openness.ToResoniteLinkField());
members.Add("Widen", Widen.ToResoniteLinkField());
members.Add("Squeeze", Squeeze.ToResoniteLinkField());
members.Add("Frown", Frown.ToResoniteLinkField());
members.Add("InnerBrowVertical", InnerBrowVertical.ToResoniteLinkField());
members.Add("OuterBrowVertical", OuterBrowVertical.ToResoniteLinkField());
}

}
            }
}
