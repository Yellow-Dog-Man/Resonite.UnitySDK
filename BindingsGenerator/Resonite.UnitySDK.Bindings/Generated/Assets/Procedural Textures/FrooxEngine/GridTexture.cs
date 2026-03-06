
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridTexture
// Generated on: pátek 6. března 2026 14:18:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridTexture")]
public partial class GridTexture : global::FrooxEngine.ProceduralTexture

{
    public UnityEngine.ColorX BackgroundColor { get => BackgroundColor_Element.Data; set => BackgroundColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BackgroundColor_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.GridTexture.Grid>, global::FrooxEngine.GridTexture.Grid> Grids = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BackgroundColor", BackgroundColor_Element.ToLinkField(context));
members.Add("Grids", Grids.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
