
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RelativePositioner
// Generated on: čtvrtek 26. února 2026 10:04:41
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
    public global::FrooxEngine.Slot Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Reference_Element = new();
public global::FrooxEngine.RootSpace ReferenceBoundsSpace = new();
public UnityEngine.Vector3 ReferenceAnchor { get => ReferenceAnchor_Element.Data; set => ReferenceAnchor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ReferenceAnchor_Element = new();
public UnityEngine.Vector3 ReferenceOffset { get => ReferenceOffset_Element.Data; set => ReferenceOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ReferenceOffset_Element = new();
public global::System.Boolean DestroyAfterDone { get => DestroyAfterDone_Element.Data; set => DestroyAfterDone_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DestroyAfterDone_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference_Element.Data.ToResoniteReference(context));
members.Add("ReferenceBoundsSpace", new ResoniteLink.SyncObject() { Members = ReferenceBoundsSpace.CollectMembers(context) });
members.Add("ReferenceAnchor", ReferenceAnchor_Element.Data.ToResoniteLinkField());
members.Add("ReferenceOffset", ReferenceOffset_Element.Data.ToResoniteLinkField());
members.Add("DestroyAfterDone", DestroyAfterDone_Element.Data.ToResoniteLinkField());
members.Add("_target", _target_Element.Data.ToResoniteReference(context));
}

}
}
