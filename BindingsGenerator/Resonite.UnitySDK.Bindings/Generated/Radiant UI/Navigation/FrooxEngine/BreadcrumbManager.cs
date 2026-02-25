
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BreadcrumbManager
// Generated on: středa 25. února 2026 16:14:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BreadcrumbManager")]
public partial class BreadcrumbManager : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.SyncFieldList<global::System.String> Path;
public global::FrooxEngine.Slot UI_Root;
public global::FrooxEngine.BreadcrumbInterface BreadcrumbTemplate;
public global::FrooxEngine.Slot SeparatorTemplate;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Path", Path.ToResoniteReference(context));
members.Add("UI_Root", UI_Root.ToResoniteReference(context));
members.Add("BreadcrumbTemplate", BreadcrumbTemplate.ToResoniteReference(context));
members.Add("SeparatorTemplate", SeparatorTemplate.ToResoniteReference(context));
}

}
}
