
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleAligner
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleAligner")]
public partial class ScaleAligner : global::FrooxEngine.AutoAddChildrenBase

{
    public UnityEngine.Vector3 BaseSize { get => BaseSize_Element.Data; set => BaseSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> BaseSize_Element = new();
public UnityEngine.Vector3 Increment { get => Increment_Element.Data; set => Increment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Increment_Element = new();
public UnityEngine.Vector3 Multiplier { get => Multiplier_Element.Data; set => Multiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Multiplier_Element = new();
public global::System.Boolean NonUniform { get => NonUniform_Element.Data; set => NonUniform_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> NonUniform_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ScaleAligner.Target>, global::FrooxEngine.ScaleAligner.Target> _targets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseSize", BaseSize_Element.Data.ToResoniteLinkField());
members.Add("Increment", Increment_Element.Data.ToResoniteLinkField());
members.Add("Multiplier", Multiplier_Element.Data.ToResoniteLinkField());
members.Add("NonUniform", NonUniform_Element.Data.ToResoniteLinkField());
members.Add("_targets", new ResoniteLink.SyncList()
{
    Elements = _targets.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
