
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapTarget
// Generated on: pátek 13. února 2026 5:52:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SnapTarget")]
public partial class SnapTarget : global::FrooxEngine.Component, global::FrooxEngine.IGrabbableReparentBlock, global::FrooxEngine.IInteractionBlock

{
    public System.Collections.Generic.List<global::FrooxEngine.Snapper> SnapperWhitelist;
public System.Collections.Generic.List<global::System.String> SnapperKeywordWhitelist;
public global::System.Boolean DirectSnapOnly;
public global::System.Single MaximumSnapDistance;
public global::System.Single MaximumAngleDeviation;
public global::System.Single AnimationTime;
public global::System.Boolean AutoSnap;
public global::FrooxEngine.IField<global::System.Single> _snapColliderRadius;
public global::FrooxEngine.SphereCollider proxySphere;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SnapperWhitelist", new ResoniteLink.SyncList()
{
    Elements = SnapperWhitelist.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("SnapperKeywordWhitelist", new ResoniteLink.SyncList()
{
    Elements = SnapperKeywordWhitelist.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
members.Add("DirectSnapOnly", DirectSnapOnly.ToResoniteLinkField());
members.Add("MaximumSnapDistance", MaximumSnapDistance.ToResoniteLinkField());
members.Add("MaximumAngleDeviation", MaximumAngleDeviation.ToResoniteLinkField());
members.Add("AnimationTime", AnimationTime.ToResoniteLinkField());
members.Add("AutoSnap", AutoSnap.ToResoniteLinkField());
members.Add("_snapColliderRadius", new ResoniteLink.Reference() { });
members.Add("proxySphere", new ResoniteLink.Reference() { });
}

}
}
