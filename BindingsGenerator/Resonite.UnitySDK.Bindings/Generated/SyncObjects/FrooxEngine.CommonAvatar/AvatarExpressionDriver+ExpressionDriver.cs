
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarExpressionDriver+ExpressionDriver
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
    public partial class AvatarExpressionDriver
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarExpressionDriver+ExpressionDriver")]
public partial class ExpressionDriver : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<global::System.Single> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> Target_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarExpression Expression { get => Expression_Element.Data; set => Expression_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CommonAvatar.AvatarExpression>, global::FrooxEngine.CommonAvatar.AvatarExpression> Expression_Element = new();
public global::System.Boolean EstimateIfNotTracked { get => EstimateIfNotTracked_Element.Data; set => EstimateIfNotTracked_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EstimateIfNotTracked_Element = new();
public global::System.Single Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Min_Element = new();
public global::System.Single Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Max_Element = new();
public global::System.Single VolumeSupressionStrength { get => VolumeSupressionStrength_Element.Data; set => VolumeSupressionStrength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VolumeSupressionStrength_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Expression", Expression_Element.ToLinkField(context));
members.Add("EstimateIfNotTracked", EstimateIfNotTracked_Element.ToLinkField(context));
members.Add("Min", Min_Element.ToLinkField(context));
members.Add("Max", Max_Element.ToLinkField(context));
members.Add("VolumeSupressionStrength", VolumeSupressionStrength_Element.ToLinkField(context));
}

}
            }
}
