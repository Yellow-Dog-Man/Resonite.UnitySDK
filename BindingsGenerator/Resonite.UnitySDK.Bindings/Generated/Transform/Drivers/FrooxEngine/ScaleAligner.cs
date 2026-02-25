
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleAligner
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleAligner")]
public partial class ScaleAligner : global::FrooxEngine.AutoAddChildrenBase

{
    public UnityEngine.Vector3 BaseSize;
public UnityEngine.Vector3 Increment;
public UnityEngine.Vector3 Multiplier;
public global::System.Boolean NonUniform;
public System.Collections.Generic.List<global::FrooxEngine.ScaleAligner.Target> _targets;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseSize", BaseSize.ToResoniteLinkField());
members.Add("Increment", Increment.ToResoniteLinkField());
members.Add("Multiplier", Multiplier.ToResoniteLinkField());
members.Add("NonUniform", NonUniform.ToResoniteLinkField());
members.Add("_targets", new ResoniteLink.SyncList()
{
    Elements = _targets.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
