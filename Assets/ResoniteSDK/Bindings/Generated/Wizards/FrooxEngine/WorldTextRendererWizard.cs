
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldTextRendererWizard
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("Material", new ResoniteLink.Reference() { });
members.Add("Font", new ResoniteLink.Reference() { });
members.Add("ProcessDisabled", ProcessDisabled.ToResoniteLinkField());
members.Add("ProcessStandaloneRenderers", ProcessStandaloneRenderers.ToResoniteLinkField());
members.Add("ProcessUIXRenderers", ProcessUIXRenderers.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("_tag", new ResoniteLink.Reference() { });
}

}
}
