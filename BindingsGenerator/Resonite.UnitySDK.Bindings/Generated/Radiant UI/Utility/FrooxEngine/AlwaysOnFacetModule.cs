
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AlwaysOnFacetModule
// Generated on: pátek 6. března 2026 14:19:02
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AlwaysOnFacetModule")]
public partial class AlwaysOnFacetModule : global::FrooxEngine.Component

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> _targets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targets", _targets.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
