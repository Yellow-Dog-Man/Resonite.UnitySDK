
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GlueTool
// Generated on: úterý 24. února 2026 18:20:11
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GlueMode", GlueMode.ToResoniteLinkField());
members.Add("_indicatorColor", _indicatorColor.ToResoniteReference(context));
members.Add("_activeGlues", new ResoniteLink.SyncList()
{
    Elements = _activeGlues.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
