
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BreadcrumbManager
// Generated on: čtvrtek 26. února 2026 12:28:02
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.SyncFieldList<global::System.String> Path { get => Path_Element.Data; set => Path_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.SyncFieldList<global::System.String>>, global::FrooxEngine.SyncFieldList<global::System.String>> Path_Element = new();
public global::FrooxEngine.Slot UI_Root { get => UI_Root_Element.Data; set => UI_Root_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> UI_Root_Element = new();
public global::FrooxEngine.BreadcrumbInterface BreadcrumbTemplate { get => BreadcrumbTemplate_Element.Data; set => BreadcrumbTemplate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BreadcrumbInterface>, global::FrooxEngine.BreadcrumbInterface> BreadcrumbTemplate_Element = new();
public global::FrooxEngine.Slot SeparatorTemplate { get => SeparatorTemplate_Element.Data; set => SeparatorTemplate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> SeparatorTemplate_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Path", Path_Element.ToLinkReference(context));
members.Add("UI_Root", UI_Root_Element.ToLinkReference(context));
members.Add("BreadcrumbTemplate", BreadcrumbTemplate_Element.ToLinkReference(context));
members.Add("SeparatorTemplate", SeparatorTemplate_Element.ToLinkReference(context));
}

}
}
