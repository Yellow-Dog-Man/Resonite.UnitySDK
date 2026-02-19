
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldLightSourcesWizard
// Generated on: čtvrtek 19. února 2026 8:00:34
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root.ToResoniteReference(context));
members.Add("ProcessPointLights", ProcessPointLights.ToResoniteLinkField());
members.Add("ProcessSpotLights", ProcessSpotLights.ToResoniteLinkField());
members.Add("ProcessDirectionalLights", ProcessDirectionalLights.ToResoniteLinkField());
members.Add("ProcessDisabled", ProcessDisabled.ToResoniteLinkField());
members.Add("TargetShadowType", TargetShadowType.ToResoniteLinkField());
members.Add("_tag", _tag.ToResoniteReference(context));
members.Add("_intensityField", _intensityField.ToResoniteReference(context));
members.Add("_rangeField", _rangeField.ToResoniteReference(context));
}

}
}
