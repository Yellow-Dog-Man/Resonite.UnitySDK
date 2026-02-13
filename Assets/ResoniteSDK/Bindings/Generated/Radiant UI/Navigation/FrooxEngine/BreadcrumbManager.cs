
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BreadcrumbManager
// Generated on: pátek 13. února 2026 5:52:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BreadcrumbManager")]
public partial class BreadcrumbManager : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.SyncFieldList<global::System.String> Path;
public global::FrooxEngine.Slot UI_Root;
public global::FrooxEngine.BreadcrumbInterface BreadcrumbTemplate;
public global::FrooxEngine.Slot SeparatorTemplate;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Path", new ResoniteLink.Reference() { });
members.Add("UI_Root", new ResoniteLink.Reference() { });
members.Add("BreadcrumbTemplate", new ResoniteLink.Reference() { });
members.Add("SeparatorTemplate", new ResoniteLink.Reference() { });
}

}
}
