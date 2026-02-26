
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldLightSourcesWizard
// Generated on: čtvrtek 26. února 2026 12:28:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldLightSourcesWizard")]
public partial class WorldLightSourcesWizard : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public global::System.Boolean ProcessPointLights { get => ProcessPointLights_Element.Data; set => ProcessPointLights_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ProcessPointLights_Element = new();
public global::System.Boolean ProcessSpotLights { get => ProcessSpotLights_Element.Data; set => ProcessSpotLights_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ProcessSpotLights_Element = new();
public global::System.Boolean ProcessDirectionalLights { get => ProcessDirectionalLights_Element.Data; set => ProcessDirectionalLights_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ProcessDirectionalLights_Element = new();
public global::System.Boolean ProcessDisabled { get => ProcessDisabled_Element.Data; set => ProcessDisabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ProcessDisabled_Element = new();
public global::Renderite.Shared.ShadowType TargetShadowType { get => TargetShadowType_Element.Data; set => TargetShadowType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.ShadowType>, global::Renderite.Shared.ShadowType> TargetShadowType_Element = new();
public global::FrooxEngine.UIX.TextField _tag { get => _tag_Element.Data; set => _tag_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _tag_Element = new();
public global::FrooxEngine.FloatTextEditorParser _intensityField { get => _intensityField_Element.Data; set => _intensityField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> _intensityField_Element = new();
public global::FrooxEngine.FloatTextEditorParser _rangeField { get => _rangeField_Element.Data; set => _rangeField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> _rangeField_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("ProcessPointLights", ProcessPointLights_Element.ToLinkField(context));
members.Add("ProcessSpotLights", ProcessSpotLights_Element.ToLinkField(context));
members.Add("ProcessDirectionalLights", ProcessDirectionalLights_Element.ToLinkField(context));
members.Add("ProcessDisabled", ProcessDisabled_Element.ToLinkField(context));
members.Add("TargetShadowType", TargetShadowType_Element.ToLinkField(context));
members.Add("_tag", _tag_Element.ToLinkReference(context));
members.Add("_intensityField", _intensityField_Element.ToLinkReference(context));
members.Add("_rangeField", _rangeField_Element.ToLinkReference(context));
}

}
}
