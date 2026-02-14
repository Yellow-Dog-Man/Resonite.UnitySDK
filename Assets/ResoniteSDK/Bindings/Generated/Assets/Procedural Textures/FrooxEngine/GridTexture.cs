
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridTexture
// Generated on: sobota 14. února 2026 8:57:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridTexture")]
public partial class GridTexture : global::FrooxEngine.ProceduralTexture

{
    public UnityEngine.ColorX BackgroundColor;
public System.Collections.Generic.List<global::FrooxEngine.GridTexture.Grid> Grids;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BackgroundColor", BackgroundColor.ToResoniteLinkField());
members.Add("Grids", new ResoniteLink.SyncList()
{
    Elements = Grids.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
