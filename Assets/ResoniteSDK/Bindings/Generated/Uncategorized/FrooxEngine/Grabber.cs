
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Grabber
// Generated on: úterý 24. února 2026 18:17:49
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Grabber")]
public partial class Grabber : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.User AutoUpdateUser;
public global::System.Single ReleaseCheckRadius;
public global::Renderite.Shared.BodyNode CorrespondingBodyNode;
public global::FrooxEngine.Grabber _scaleReference;
public UnityEngine.Vector3 _baseScale;
public global::System.Single _baseDistance;
public global::FrooxEngine.Slot _holderSlot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AutoUpdateUser", AutoUpdateUser.ToResoniteReference(context));
members.Add("ReleaseCheckRadius", ReleaseCheckRadius.ToResoniteLinkField());
members.Add("CorrespondingBodyNode", CorrespondingBodyNode.ToResoniteLinkField());
members.Add("_scaleReference", _scaleReference.ToResoniteReference(context));
members.Add("_baseScale", _baseScale.ToResoniteLinkField());
members.Add("_baseDistance", _baseDistance.ToResoniteLinkField());
members.Add("_holderSlot", _holderSlot.ToResoniteReference(context));
}

}
}
