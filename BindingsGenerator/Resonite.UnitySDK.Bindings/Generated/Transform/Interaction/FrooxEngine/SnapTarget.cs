
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SnapTarget
// Generated on: čtvrtek 26. února 2026 12:28:08
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Snapper>, global::FrooxEngine.Snapper, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Snapper>, global::FrooxEngine.Snapper>> SnapperWhitelist = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> SnapperKeywordWhitelist = new();
public global::System.Boolean DirectSnapOnly { get => DirectSnapOnly_Element.Data; set => DirectSnapOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DirectSnapOnly_Element = new();
public global::System.Single MaximumSnapDistance { get => MaximumSnapDistance_Element.Data; set => MaximumSnapDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaximumSnapDistance_Element = new();
public global::System.Single MaximumAngleDeviation { get => MaximumAngleDeviation_Element.Data; set => MaximumAngleDeviation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaximumAngleDeviation_Element = new();
public global::System.Single AnimationTime { get => AnimationTime_Element.Data; set => AnimationTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnimationTime_Element = new();
public global::System.Boolean AutoSnap { get => AutoSnap_Element.Data; set => AutoSnap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoSnap_Element = new();
public global::FrooxEngine.IField<global::System.Single> _snapColliderRadius { get => _snapColliderRadius_Element.Data; set => _snapColliderRadius_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _snapColliderRadius_Element = new();
public global::FrooxEngine.SphereCollider proxySphere { get => proxySphere_Element.Data; set => proxySphere_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SphereCollider>, global::FrooxEngine.SphereCollider> proxySphere_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SnapperWhitelist", SnapperWhitelist.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("SnapperKeywordWhitelist", SnapperKeywordWhitelist.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("DirectSnapOnly", DirectSnapOnly_Element.ToLinkField(context));
members.Add("MaximumSnapDistance", MaximumSnapDistance_Element.ToLinkField(context));
members.Add("MaximumAngleDeviation", MaximumAngleDeviation_Element.ToLinkField(context));
members.Add("AnimationTime", AnimationTime_Element.ToLinkField(context));
members.Add("AutoSnap", AutoSnap_Element.ToLinkField(context));
members.Add("_snapColliderRadius", _snapColliderRadius_Element.ToLinkReference(context));
members.Add("proxySphere", proxySphere_Element.ToLinkReference(context));
}

}
}
