
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SingleShapeCharacterControllerManager
// Generated on: pátek 13. února 2026 23:21:42
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UseUserHeadHeightWhenAvailable", UseUserHeadHeightWhenAvailable.ToResoniteLinkField());
members.Add("HeadHeightOffset", HeadHeightOffset.ToResoniteLinkField());
members.Add("CrouchTargetWidth", CrouchTargetWidth.ToResoniteLinkField());
members.Add("CrouchStart", CrouchStart.ToResoniteLinkField());
members.Add("CrouchEnd", CrouchEnd.ToResoniteLinkField());
members.Add("DefaultHeight", DefaultHeight.ToResoniteLinkField());
members.Add("DefaultWidth", DefaultWidth.ToResoniteLinkField());
members.Add("RootAtBottom", RootAtBottom.ToResoniteLinkField());
members.Add("TargetHeight", new ResoniteLink.Reference() { });
members.Add("TargetWidth", new ResoniteLink.Reference() { });
members.Add("TargetOffset", new ResoniteLink.Reference() { });
}

}
}
