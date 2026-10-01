
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FABRIK_Chain
// Generated on: pátek 14. srpna 2026 21:57:42
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FABRIK_Chain")]
public partial class FABRIK_Chain : global::FrooxEngine.Component

{
    public global::System.Int32 MaxIterations { get => MaxIterations_Element.Data; set => MaxIterations_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxIterations_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.FABRIK_Chain.ChainBone>, global::FrooxEngine.FABRIK_Chain.ChainBone> Bones = new();
public global::System.Boolean ShowDebugVisuals { get => ShowDebugVisuals_Element.Data; set => ShowDebugVisuals_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowDebugVisuals_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxIterations", MaxIterations_Element.ToLinkField(context));
members.Add("Bones", Bones.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("ShowDebugVisuals", ShowDebugVisuals_Element.ToLinkField(context));
}

}
}
