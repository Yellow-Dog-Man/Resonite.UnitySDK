
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FacetAnchorsSettings
// Generated on: čtvrtek 26. února 2026 10:04:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FacetAnchorsSettings")]
public partial class FacetAnchorsSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.FacetAnchorsSettings>

{
    public global::System.Boolean UseFacetAnchors { get => UseFacetAnchors_Element.Data; set => UseFacetAnchors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseFacetAnchors_Element = new();
public global::Renderite.Shared.Chirality FacetAnchorToggle { get => FacetAnchorToggle_Element.Data; set => FacetAnchorToggle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> FacetAnchorToggle_Element = new();
public global::System.Single AnimationSpeed { get => AnimationSpeed_Element.Data; set => AnimationSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnimationSpeed_Element = new();
public global::System.Boolean ShowContainerBackground { get => ShowContainerBackground_Element.Data; set => ShowContainerBackground_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowContainerBackground_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseFacetAnchors", UseFacetAnchors_Element.Data.ToResoniteLinkField());
members.Add("FacetAnchorToggle", FacetAnchorToggle_Element.Data.ToResoniteLinkField());
members.Add("AnimationSpeed", AnimationSpeed_Element.Data.ToResoniteLinkField());
members.Add("ShowContainerBackground", ShowContainerBackground_Element.Data.ToResoniteLinkField());
}

}
}
