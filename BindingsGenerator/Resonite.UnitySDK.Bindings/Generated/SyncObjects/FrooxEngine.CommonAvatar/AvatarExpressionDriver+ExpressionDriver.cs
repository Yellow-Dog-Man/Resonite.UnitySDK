
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarExpressionDriver+ExpressionDriver
// Generated on: středa 25. února 2026 16:14:45
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
    public partial class AvatarExpressionDriver
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarExpressionDriver+ExpressionDriver")]
public partial class ExpressionDriver : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<global::System.Single> Target;
public global::FrooxEngine.CommonAvatar.AvatarExpression Expression;
public global::System.Boolean EstimateIfNotTracked;
public global::System.Single Min;
public global::System.Single Max;
public global::System.Single VolumeSupressionStrength;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Expression", Expression.ToResoniteLinkField());
members.Add("EstimateIfNotTracked", EstimateIfNotTracked.ToResoniteLinkField());
members.Add("Min", Min.ToResoniteLinkField());
members.Add("Max", Max.ToResoniteLinkField());
members.Add("VolumeSupressionStrength", VolumeSupressionStrength.ToResoniteLinkField());
}

}
            }
}
