
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AutoLookAtUser
// Generated on: pátek 13. února 2026 5:52:25
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AutoLookAtUser")]
public partial class AutoLookAtUser : global::FrooxEngine.Component

{
    public global::System.Single RetargetDistance;
public global::System.Single LerpSpeed;
public global::FrooxEngine.User TargetedUser;
public global::System.Boolean AutoTarget;
public global::System.Boolean ExcludeActiveUser;
public UnityEngine.Vector3 SwingReference;
public UnityEngine.Vector3 TwistReference;
public global::System.Single MaxSwing;
public global::System.Single MaxTwist;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("RetargetDistance", RetargetDistance.ToResoniteLinkField());
members.Add("LerpSpeed", LerpSpeed.ToResoniteLinkField());
members.Add("TargetedUser", new ResoniteLink.Reference() { });
members.Add("AutoTarget", AutoTarget.ToResoniteLinkField());
members.Add("ExcludeActiveUser", ExcludeActiveUser.ToResoniteLinkField());
members.Add("SwingReference", SwingReference.ToResoniteLinkField());
members.Add("TwistReference", TwistReference.ToResoniteLinkField());
members.Add("MaxSwing", MaxSwing.ToResoniteLinkField());
members.Add("MaxTwist", MaxTwist.ToResoniteLinkField());
members.Add("_rotation", new ResoniteLink.Reference() { });
}

}
}
