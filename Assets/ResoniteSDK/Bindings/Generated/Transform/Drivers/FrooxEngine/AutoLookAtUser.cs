
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AutoLookAtUser
// Generated on: sobota 14. února 2026 8:58:38
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RetargetDistance", RetargetDistance.ToResoniteLinkField());
members.Add("LerpSpeed", LerpSpeed.ToResoniteLinkField());
members.Add("TargetedUser", TargetedUser.ToResoniteReference(context));
members.Add("AutoTarget", AutoTarget.ToResoniteLinkField());
members.Add("ExcludeActiveUser", ExcludeActiveUser.ToResoniteLinkField());
members.Add("SwingReference", SwingReference.ToResoniteLinkField());
members.Add("TwistReference", TwistReference.ToResoniteLinkField());
members.Add("MaxSwing", MaxSwing.ToResoniteLinkField());
members.Add("MaxTwist", MaxTwist.ToResoniteLinkField());
members.Add("_rotation", _rotation.ToResoniteReference(context));
}

}
}
