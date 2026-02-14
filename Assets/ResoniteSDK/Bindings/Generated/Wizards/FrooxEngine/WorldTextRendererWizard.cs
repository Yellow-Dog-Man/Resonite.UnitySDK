
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldTextRendererWizard
// Generated on: sobota 14. února 2026 8:58:51
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldTextRendererWizard")]
public partial class WorldTextRendererWizard : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.Slot Root;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> Material;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.FontSet> Font;
public global::System.Boolean ProcessDisabled;
public global::System.Boolean ProcessStandaloneRenderers;
public global::System.Boolean ProcessUIXRenderers;
public UnityEngine.ColorX Color;
public global::FrooxEngine.UIX.TextField _tag;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root.ToResoniteReference(context));
members.Add("Material", Material.ToResoniteReference(context));
members.Add("Font", Font.ToResoniteReference(context));
members.Add("ProcessDisabled", ProcessDisabled.ToResoniteLinkField());
members.Add("ProcessStandaloneRenderers", ProcessStandaloneRenderers.ToResoniteLinkField());
members.Add("ProcessUIXRenderers", ProcessUIXRenderers.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("_tag", _tag.ToResoniteReference(context));
}

}
}
