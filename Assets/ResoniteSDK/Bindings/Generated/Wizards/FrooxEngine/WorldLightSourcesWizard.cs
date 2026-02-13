
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldLightSourcesWizard
// Generated on: pátek 13. února 2026 23:23:21
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldLightSourcesWizard")]
public partial class WorldLightSourcesWizard : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.Slot Root;
public global::System.Boolean ProcessPointLights;
public global::System.Boolean ProcessSpotLights;
public global::System.Boolean ProcessDirectionalLights;
public global::System.Boolean ProcessDisabled;
public global::Renderite.Shared.ShadowType TargetShadowType;
public global::FrooxEngine.UIX.TextField _tag;
public global::FrooxEngine.FloatTextEditorParser _intensityField;
public global::FrooxEngine.FloatTextEditorParser _rangeField;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("ProcessPointLights", ProcessPointLights.ToResoniteLinkField());
members.Add("ProcessSpotLights", ProcessSpotLights.ToResoniteLinkField());
members.Add("ProcessDirectionalLights", ProcessDirectionalLights.ToResoniteLinkField());
members.Add("ProcessDisabled", ProcessDisabled.ToResoniteLinkField());
members.Add("TargetShadowType", TargetShadowType.ToResoniteLinkField());
members.Add("_tag", new ResoniteLink.Reference() { });
members.Add("_intensityField", new ResoniteLink.Reference() { });
members.Add("_rangeField", new ResoniteLink.Reference() { });
}

}
}
