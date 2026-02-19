
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SingleShapeCharacterControllerManager
// Generated on: čtvrtek 19. února 2026 7:59:02
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SingleShapeCharacterControllerManager")]
public partial class SingleShapeCharacterControllerManager : global::FrooxEngine.Component

{
    public global::System.Boolean UseUserHeadHeightWhenAvailable;
public global::System.Single HeadHeightOffset;
public global::System.Single CrouchTargetWidth;
public global::System.Single CrouchStart;
public global::System.Single CrouchEnd;
public global::System.Single DefaultHeight;
public global::System.Single DefaultWidth;
public global::System.Boolean RootAtBottom;
public global::FrooxEngine.IField<global::System.Single> TargetHeight;
public global::FrooxEngine.IField<global::System.Single> TargetWidth;
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseUserHeadHeightWhenAvailable", UseUserHeadHeightWhenAvailable.ToResoniteLinkField());
members.Add("HeadHeightOffset", HeadHeightOffset.ToResoniteLinkField());
members.Add("CrouchTargetWidth", CrouchTargetWidth.ToResoniteLinkField());
members.Add("CrouchStart", CrouchStart.ToResoniteLinkField());
members.Add("CrouchEnd", CrouchEnd.ToResoniteLinkField());
members.Add("DefaultHeight", DefaultHeight.ToResoniteLinkField());
members.Add("DefaultWidth", DefaultWidth.ToResoniteLinkField());
members.Add("RootAtBottom", RootAtBottom.ToResoniteLinkField());
members.Add("TargetHeight", TargetHeight.ToResoniteReference(context));
members.Add("TargetWidth", TargetWidth.ToResoniteReference(context));
members.Add("TargetOffset", TargetOffset.ToResoniteReference(context));
}

}
}
