
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GlueTool
// Generated on: pátek 13. února 2026 5:52:23
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GlueTool")]
public partial class GlueTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.Glue.Mode GlueMode;
public global::FrooxEngine.IField<UnityEngine.ColorX> _indicatorColor;
public System.Collections.Generic.List<global::FrooxEngine.Glue> _activeGlues;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("GlueMode", GlueMode.ToResoniteLinkField());
members.Add("_indicatorColor", new ResoniteLink.Reference() { });
members.Add("_activeGlues", new ResoniteLink.SyncList()
{
    Elements = _activeGlues.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
}

}
}
