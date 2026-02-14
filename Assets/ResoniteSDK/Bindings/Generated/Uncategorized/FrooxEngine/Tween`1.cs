
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Tween<>
// Generated on: sobota 14. února 2026 8:58:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Tween<>")]
public partial class Tween<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.User User;
public global::FrooxEngine.IField<T> Target;
public global::FrooxEngine.Slot OnlyUnderParent;
public T From;
public T To;
public global::System.Double StartTime;
public global::System.Single Duration;
public global::FrooxEngine.CurvePreset Curve;
public global::System.Boolean LocalCallback;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
members.Add("OnlyUnderParent", OnlyUnderParent.ToResoniteReference(context));
members.Add("From", From.ToResoniteLinkField());
members.Add("To", To.ToResoniteLinkField());
members.Add("StartTime", StartTime.ToResoniteLinkField());
members.Add("Duration", Duration.ToResoniteLinkField());
members.Add("Curve", Curve.ToResoniteLinkField());
members.Add("LocalCallback", LocalCallback.ToResoniteLinkField());
}

}
}
