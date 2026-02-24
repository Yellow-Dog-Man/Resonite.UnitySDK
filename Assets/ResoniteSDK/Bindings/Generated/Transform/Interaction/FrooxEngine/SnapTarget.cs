
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapTarget
// Generated on: úterý 24. února 2026 18:20:15
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SnapperWhitelist", new ResoniteLink.SyncList()
{
    Elements = SnapperWhitelist.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("SnapperKeywordWhitelist", new ResoniteLink.SyncList()
{
    Elements = SnapperKeywordWhitelist.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("DirectSnapOnly", DirectSnapOnly.ToResoniteLinkField());
members.Add("MaximumSnapDistance", MaximumSnapDistance.ToResoniteLinkField());
members.Add("MaximumAngleDeviation", MaximumAngleDeviation.ToResoniteLinkField());
members.Add("AnimationTime", AnimationTime.ToResoniteLinkField());
members.Add("AutoSnap", AutoSnap.ToResoniteLinkField());
members.Add("_snapColliderRadius", _snapColliderRadius.ToResoniteReference(context));
members.Add("proxySphere", proxySphere.ToResoniteReference(context));
}

}
}
