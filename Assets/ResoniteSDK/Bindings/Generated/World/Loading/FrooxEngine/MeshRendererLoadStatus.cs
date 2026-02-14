
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshRendererLoadStatus
// Generated on: sobota 14. února 2026 8:58:51
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshRendererLoadStatus")]
public partial class MeshRendererLoadStatus : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.MeshRenderer> Renderers;
public global::System.Boolean IsLoaded;
public global::System.Single LoadProgress;
public global::System.Single ProgressWeight;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Renderers", new ResoniteLink.SyncList()
{
    Elements = Renderers.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("IsLoaded", IsLoaded.ToResoniteLinkField());
members.Add("LoadProgress", LoadProgress.ToResoniteLinkField());
members.Add("ProgressWeight", ProgressWeight.ToResoniteLinkField());
}

}
}
