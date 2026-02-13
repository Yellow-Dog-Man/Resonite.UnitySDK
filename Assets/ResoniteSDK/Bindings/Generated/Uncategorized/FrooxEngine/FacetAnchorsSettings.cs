
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FacetAnchorsSettings
// Generated on: pátek 13. února 2026 5:52:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FacetAnchorsSettings")]
public partial class FacetAnchorsSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.FacetAnchorsSettings>

{
    public global::System.Boolean UseFacetAnchors;
public global::Renderite.Shared.Chirality FacetAnchorToggle;
public global::System.Single AnimationSpeed;
public global::System.Boolean ShowContainerBackground;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UseFacetAnchors", UseFacetAnchors.ToResoniteLinkField());
members.Add("FacetAnchorToggle", FacetAnchorToggle.ToResoniteLinkField());
members.Add("AnimationSpeed", AnimationSpeed.ToResoniteLinkField());
members.Add("ShowContainerBackground", ShowContainerBackground.ToResoniteLinkField());
}

}
}
