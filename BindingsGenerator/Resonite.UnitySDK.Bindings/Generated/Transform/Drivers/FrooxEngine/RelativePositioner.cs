
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RelativePositioner
// Generated on: středa 25. února 2026 16:14:30
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RelativePositioner")]
public partial class RelativePositioner : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot Reference;
public global::FrooxEngine.RootSpace ReferenceBoundsSpace;
public UnityEngine.Vector3 ReferenceAnchor;
public UnityEngine.Vector3 ReferenceOffset;
public global::System.Boolean DestroyAfterDone;
public global::FrooxEngine.IField<UnityEngine.Vector3> _target;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference.ToResoniteReference(context));
members.Add("ReferenceBoundsSpace", new ResoniteLink.SyncObject() { Members = ReferenceBoundsSpace.CollectMembers(context) });
members.Add("ReferenceAnchor", ReferenceAnchor.ToResoniteLinkField());
members.Add("ReferenceOffset", ReferenceOffset.ToResoniteLinkField());
members.Add("DestroyAfterDone", DestroyAfterDone.ToResoniteLinkField());
members.Add("_target", _target.ToResoniteReference(context));
}

}
}
