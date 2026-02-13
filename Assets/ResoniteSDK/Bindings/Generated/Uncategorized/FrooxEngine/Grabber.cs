
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Grabber
// Generated on: pátek 13. února 2026 23:21:40
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AutoUpdateUser", new ResoniteLink.Reference() { });
members.Add("ReleaseCheckRadius", ReleaseCheckRadius.ToResoniteLinkField());
members.Add("CorrespondingBodyNode", CorrespondingBodyNode.ToResoniteLinkField());
members.Add("_scaleReference", new ResoniteLink.Reference() { });
members.Add("_baseScale", _baseScale.ToResoniteLinkField());
members.Add("_baseDistance", _baseDistance.ToResoniteLinkField());
members.Add("_holderSlot", new ResoniteLink.Reference() { });
}

}
}
